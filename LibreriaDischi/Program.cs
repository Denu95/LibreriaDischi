using LibreriaDischi;

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
disco.ListaBrani.Add(brano);
Console.WriteLine(disco);
Console.WriteLine(brano);