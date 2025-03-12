using cv5;

class Program
{
    static void Main()
    {
        try
        {
            Osobne osobneAuto = new Osobne();
            Nakladne nakladneAuto = new Nakladne();

            osobneAuto.Natankuj(Auto.TypPaliva.Benzin, 15);
            nakladneAuto.Natankuj(Auto.TypPaliva.Nafta, 100);

            osobneAuto.NastavPrepravovanyNaklad(450.7);
            nakladneAuto.NastavPrepravovanyNaklad(14988.9);

            osobneAuto.NastavPrepravovaneOsoby(4);
            nakladneAuto.NastavPrepravovaneOsoby(1);

            osobneAuto.Radio.NastavPredvolbu(1, 101.2);
            osobneAuto.Radio.PreladNaPredvolbu(1);
            osobneAuto.Radio.ZapniRadio();

            Console.WriteLine(osobneAuto.ToString());
            Console.WriteLine(nakladneAuto.ToString());


        }
        catch (Exception ex)
        {
            Console.WriteLine($"Chyba: {ex.Message}");
        }
    }
}
