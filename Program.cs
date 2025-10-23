namespace esercizio2
{
    internal class Program
    {

        static bool NumeriPari(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int Fattoriale(int n)
        {
            int m = 1;

            for (int i = 1; i <= n; i++)
            {

                m = m * i;

            }

            return m;
        }

        static int Quadrati(int n)
        {
            int q = n * n;
            return q;
        }

        static int Differenza(int n1, int n2)
        {
            int r = n1 - n2;
            return r;
        }
        static void Main(string[] args)
        {
            int num = 10, cont = 0, cont_disp = 0;

            for (int i = 1; i <= num; i++)
            {
                if (NumeriPari(i) == true)
                {
                    int fat = Fattoriale(i);
                    cont = fat + cont;
                }
                else
                {
                    int quad = Quadrati(i);
                    cont_disp = quad + cont_disp;
                }
            }
    }
}
