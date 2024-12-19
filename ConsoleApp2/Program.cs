

Console.WriteLine("kızınca tüküren hayvan hangisidir?\n a)Lama b)Deve"); // İlk soruyu sor ve kullanıcıdan giriş al

string input1 = Console.ReadLine().ToLower(); // Kullanıcının girişi küçük harfe çevriliyor


// İlk soruya verilen cevap doğru mu?
if (input1 == "a") // Cevap doğruysa
{
    Console.WriteLine("Cevabınız doğru");

    // İkinci soruyu sor
    Console.WriteLine("dünyaya en yakın gezegen hanisidir?\n a)Venüs b)Mars");
    string input2 = Console.ReadLine().ToLower();

    if (input2 == "a") // İkinci cevap doğruysa
    {
        Console.WriteLine("Cevabınız doğru.");
        Console.WriteLine("5*2+8/2-2 işleminin sonucu kaçtır? \n a)7 b)12");  // Üçüncü soruyu sor
        string input3 = Console.ReadLine().ToLower();

        if (input3 == "b") // Üçüncü cevap da doğruysa
        {
            Console.WriteLine("Cevabınız doğru.\n3 soruyuda doğru cevaplayarak büyük ödülü kazandınız.");
        }
        else // Üçüncü cevap yanlışsa
        {
            Console.WriteLine("cevabınız yanlış\n2 soruyu doğru cevaplayarak büyük ödülü kazandınız");
        }


    }
    else // İkinci cevap yanlışsa
    {
        Console.WriteLine("cevabınız yanlış");
        Console.WriteLine("5*2+8/2-2 işleminin sonucu kaçtır? \n a)7 b)12");    // Üçüncü soruyu sor
        string input3 = Console.ReadLine().ToLower();

        if (input3 == "b") // Üçüncü cevap doğruysa
        {
            Console.WriteLine("Cevabınız doğru.\n2 soruyuda doğru cevaplayarak büyük ödülü kazandınız.");
        }
        else // Üçüncü cevap yanlışsa
        {
            Console.WriteLine("cevabınız yanlış\n Büyük ödülü kaybettiniz.");
        }

    }
}


else // İlk cevap yanlışsa
{
    Console.WriteLine("Cevabınız yanlış");
    Console.WriteLine("dünyaya en yakın gezegen hanisidir?\n a)Venüs b)Mars"); // İkinci soruyu sor
    string input2 = Console.ReadLine().ToLower();

    if (input2 == "a") // İkinci cevap doğruysa
    {
        Console.WriteLine("Cevabınız doğru");
        Console.WriteLine("5*2+8/2-2 işleminin sonucu kaçtır? \n a)7 b)12");   // Üçüncü soruyu sor
        string input3 = Console.ReadLine().ToLower();

        if (input3 == "b")  // Üçüncü cevap doğruysa
        {
            Console.WriteLine("Cevabınız doğru.\n2 soruyu doğru cevaplayarak büyük ödülü kazandınız");
        }
        else // Üçüncü cevap yanlışsa
        {
            Console.WriteLine("cevabınız yanlış\nBüyük ödülü kaybettiniz");
        }

    }
    else // İkinci cevap yanlışsa
    {
        Console.WriteLine("Cevabınız yanlış.\nBüyük ödülü kaybettiniz.");
    }
}



