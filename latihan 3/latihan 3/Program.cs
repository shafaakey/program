int jamkerja = 8;
int L;
int hargaperjam = 15000;
int gajidibayar;

//cek kondisi jika lebih dari 7 jam
if (jamkerja > 7)
{

    //proses gajid ibayar
    L = jamkerja - 7;
    if (L == 1)
    {
        gajidibayar = hargaperjam * jamkerja + 10000;
    }
    else
    {
        gajidibayar = hargaperjam * jamkerja;
    }
    //proses gaji dibayar
    L = jamkerja - 7;
    if (L == 2)
    {
        gajidibayar = hargaperjam * jamkerja + 20000;
    }
    else
    {
        gajidibayar = hargaperjam * jamkerja;
    }
    //proses gaji dibayar
    L = jamkerja - 7;
    if (L == 3)
    {
        gajidibayar = hargaperjam * jamkerja + 30000;
    }
    else
    {
        gajidibayar = hargaperjam * jamkerja;
    }
    //proses gaji dibayar
    L = jamkerja - 7;
    if (L == 4)
    {
        gajidibayar = hargaperjam * jamkerja + 100000;
    }
    else
    {
        gajidibayar = hargaperjam * jamkerja;
    }
    //jika normal
    Console.WriteLine("Tampilkan Gaji Dibayar :" + gajidibayar);
    Console.ReadKey();
}
