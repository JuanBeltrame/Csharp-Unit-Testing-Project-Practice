namespace _01._0._01_StringExtendido
{
    public static class StringExtendido
    {
        public static int ContarPalabras(this string str)
        {
            return str.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int ContarPalabras(this string str, int incremento)
        {
            return str.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length * incremento;
        }

        public static int ContarPalabras2(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException();
            }

            return str.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int ContarPalabras3(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException();
            }

            return str.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int ContarVocales(this string texto)
        {
            char[] vocales = ['a', 'e', 'i', 'o', 'u'];
            return ContarCaracteres(texto, vocales);
        }

        public static int ContarVocalesException(this string texto)
        {
            char[] vocales = ['a', 'e', 'i', 'o', 'u'];
            return ContarCaracteresException(texto, vocales);
        }

        public static int ContarCaracteres(this string texto, char caracter)
        {
            return ContarCaracteres(texto, new char[] { caracter });
        }

        private static int ContarCaracteres(this string texto, char[] caracteres)
        {
            if (string.IsNullOrEmpty(texto))
                return 0;

            texto = texto.ToLower();

            int contador = 0;

            foreach (char caracter in texto)
            {
                if (caracteres.Contains(caracter))
                {
                    contador++;
                }
            }

            return contador;
        }

        public static int ContarCaracteresException(this string texto, char caracter)
        {
            return ContarCaracteresException(texto, new char[] { caracter });
        }

        private static int ContarCaracteresException(this string texto, char[] caracteres)
        {
            if (string.IsNullOrEmpty(texto))
                throw new BusinessException("El texto es nulo");

            texto = texto.ToLower();

            int contador = 0;

            foreach (char caracter in texto)
            {
                if (caracteres.Contains(caracter))
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}
