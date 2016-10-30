using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Edit
{
    public static class PkmString
    {
        static char[] refMatrix = {
             ' ', 'À', 'Á', 'Â', 'Ç', 'È', 'É', 'Ê', 'Ë', 'Ì', 'こ', 'Î', 'Ï', 'Ò', 'Ó', 'Ô',
             'Œ', 'Ù', 'Ú', 'Û', 'Ñ', 'ß', 'à', 'á', 'ね', 'ç', 'è', 'é', 'ê', 'ë', 'ì', 'ま',
             'î', 'ï', 'ò', 'ó', 'ô', 'œ', 'ù', 'ú', 'û', 'ñ', 'º', 'ª', '\x2C', '&', '+', 'あ',
             'ぃ', 'ぅ', 'ぇ', 'ぉ', 'æ', '=', 'ょ', 'が', 'ぎ', 'ぐ', 'げ', 'ご', 'ざ', 'じ', 'ず', 'ぜ',
             'ぞ', 'だ', 'ぢ', 'づ', 'で', 'ど', 'ば', 'び', 'ぶ', 'べ', 'ぼ', 'ぱ', 'ぴ', 'ぷ', 'ぺ', 'ぽ',
             'っ', '¿', '¡', 'ø', 'å', '>', '*', '¤', '#', '<', 'Í', '%', '(', ')', 'セ', 'ソ',
             'タ', 'チ', 'ツ', 'テ',  'ト', 'ナ', 'ニ', 'ヌ', 'â', 'ノ', 'ハ', 'ヒ', 'フ', 'ヘ', 'ホ', 'í',
             'ミ', 'ム', 'メ', 'モ', 'ヤ', 'ユ', 'ヨ', 'ラ', 'リ', '⬆', '⬇', '⬅', '➡', 'ヲ', 'ン', 'ァ',
             'ィ', 'ゥ', 'ェ', 'ォ', 'ャ', 'ュ', 'ョ', 'ガ', 'ギ', 'グ', 'ゲ', 'ゴ', 'ザ', 'ジ', 'ズ', 'ゼ',
             'ゾ', 'ダ', 'ヂ', 'ヅ', 'デ', 'ド', 'バ', 'ビ', 'ブ', 'ベ', 'ボ', 'パ', 'ピ', 'プ', 'ペ', 'ポ',
             'ッ', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '!', '?', '.', '-', '・',
             '_', '“', '”', '‘', '’', '♂', '♀', '$', ',', '×', '/', 'A', 'B', 'C', 'D', 'E',
             'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
             'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
             'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '▶',
             ':', 'Ä', 'Ö', 'Ü', 'ä', 'ö', 'ü', '⬆', '⬇', '⬅', '➡', '\x4', '\x3', '\x2', '\x1', '\0'
        };

        const byte rightMask = 15, leftMask = 15 << 4;

        public static string GetString(byte[] txtByte) {
            byte left = 0, right = 0;
            char[] text = new char[txtByte.Length];

            for (int i = 0; i < txtByte.Length; i++) {
                left = (byte)((txtByte[i] & leftMask) >> 4);
                right = (byte)(txtByte[i] & rightMask);
                text[i] = refMatrix[(left * 16) + right];
            }

            return new string (text);
        }

        public static byte[] GetBytes(string text)
        {
            byte left = 0, right = 0;
            char[] chars = text.ToCharArray();
            byte[] txtByte = new byte[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                int index = Array.IndexOf(refMatrix, chars[i]);
                left = (byte)(index / 16); right = (byte)(index % 16);
                txtByte[i] = (byte)((left << 4) | right);
            }

            return txtByte;
        }
    }
}
