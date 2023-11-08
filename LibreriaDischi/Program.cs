namespace LibreriaDischi
{
    public class Program
    {
        private static void Main(string[] args)
        {
            SupportoMusicale disco = new()
            {
                Nome = "Boh",
                Descrizione = "è bello",
                Prezzo = 9.99m
            };

            Brani brano = new()
            {
                Codice = 001,
                Titolo = "uè",
                Genere = "rock",
                Durata = 3.24m
            };

            Artisti artista = new()
            {
                Nome = "Boh",
                Biografia = "è giovane, bello",
                Nazionalita = "e anche abbronzato"

            };
            disco.ListaBrani.Add(brano);
            brano.ListaArtisti.Add(artista);

            Console.WriteLine(disco);
            Console.WriteLine(brano);
            Console.WriteLine(artista);
        }
    }
}