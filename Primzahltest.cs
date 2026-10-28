
        {
            int n = LeseInt("n = ");
            bool prim = true;
            if (n < 2)
            {
                prim = false;                 // 0, 1 und negative Zahlen sind nicht prim
            }
            else
            {
                int i = 2;
                while (i * i <= n && prim)    // es genügt, bis zur Wurzel von n zu prüfen
                {
                    if (n % i == 0)
                    {
                        prim = false;
                    }
                    i = i + 1;
                }
            }
            Console.WriteLine(n + (prim ? " ist eine Primzahl" : " ist keine Primzahl"));
        }
