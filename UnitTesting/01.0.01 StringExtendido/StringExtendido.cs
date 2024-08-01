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
            if (string.IsNullOrEmpty(texto))
                return 0;

            texto = texto.ToLower();
            char[] vocales = ['a', 'e', 'i', 'o', 'u'];
            int contador = 0;

            foreach (char caracter in texto)
            {
                if (vocales.Contains(caracter))
                {
                    contador++;
                }
            }

            return contador;
        }

        public static int ContarCaracteres(this string texto, char caracter)
        {
            if (string.IsNullOrEmpty(texto))
                return 0;

            int contador = 0;

            foreach (char caracterTexto in texto)
            {
                if (caracterTexto == caracter)
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
