string currentRoom = "basement";
// string currentRoom5A="true";
// string currentRoom6 = "true";
// string currentRoom6A = "true";
// string currentRoom6B = "true";


string direction = "";



while (currentRoom != "end")
{
    if (currentRoom == "basement")
    {
        Console.WriteLine("***Du är i en kall källare**");
        Console.WriteLine("***Du vet inte vart du är och det är kallt***");
        Console.WriteLine("Jag måste ta mig där ifrån ");
        direction = Console.ReadLine();
        Console.Clear();

        if (direction == "Vänster")
        {
            Console.WriteLine("Sten golvet är kallt och fuktigt");
            Console.WriteLine("Jag känner mig genom mörkret och hittar något som känns som ett dörrhandtag");
            currentRoom = "stairs";
        }
        else
        {
            Console.WriteLine("Du vandrar genom mörkret men går in i väggen Ouch!");
        }
    }

    else if (currentRoom == "stairs")
    {
        Console.WriteLine("***Du är i en lång knarrig trappa***");

        direction = Console.ReadLine();

        if (direction == "frammåt")
        {
            Console.WriteLine("du går upp för den kalla snea trappan och du känner ännu en dörr. Du öppnar dörren och går ut på parkettgolv");
            currentRoom = "hall";
        }
        else if (direction == "backa")
        {
            currentRoom = "basement";
        }
        else
        {
            Console.WriteLine("Du går in i väggen Ouch!");
        }
    }
    else if (currentRoom == "hall")
    {
        Console.WriteLine("När du kommer ut på det stora parkettgolvet så känner du av att det är ett stort rumm du befinner dig i.");
        Console.WriteLine("Det ekar lite efter varje fotsteg men du känner dig iaktagen");

        direction = Console.ReadLine();

        if (direction == "Vänster")
        {
            Console.WriteLine("rädslan för att gå in i något är större nu när rummet är så stort");
            Console.WriteLine("Du går med armarna utsträkta för att känna när väggen är framför dig eller bara för att känna om något är framför dig. ");
            Console.WriteLine("Helt plöttsligt slår du i din kalla fot i en dörrkarm. Du är glad över att ha hittat en dörröppning men haltar");
            currentRoom = "kitchen";
        }
        else if (direction == "höger")
        {
            Console.WriteLine("Rummet känns ovanligt tomt");
            Console.WriteLine("Rummets mörker slukar dig innan du känner en metaldörr. Dörren känns robust och går inte att få upp utan andra verktyg.");

            currentRoom = "hallroom";
        }
        else if (direction == "frammåt")
        {
            Console.WriteLine();

            currentRoom = "cleaning scrub";
        }
    }

    else if (currentRoom == "kitchen")
    {
        if (direction == "Vänster")
        {
            Console.WriteLine("");
            currentRoom = "stairs2";
        }
        else if (direction == "höger")
        {
            Console.WriteLine("du väljer att åka tillbaka");
            currentRoom = "hall";
        }
        else
        {
            Console.WriteLine("Du går in i väggen Ouch!");
        }
    }
    else if (currentRoom == "stairs2")
    {
        if (direction == "frammåt")
        {
            Console.WriteLine();
            Console.WriteLine();
            currentRoom = "livingroom";
        }
        else if (direction == "bakåt")
        {
            Console.WriteLine("Lika bra att gå tillbaka");
            currentRoom = "kitchen";
        }
        else
        {
            Console.WriteLine("Du går rakt in i väggen din jädra rotfrukt");
            Console.WriteLine("aj fyfan!!");
        }
    }
    else if (currentRoom == "Livingroom")
    {
        if (direction == "frammåt")
        {
            Console.WriteLine();
            Console.WriteLine();
            currentRoom = "lobby";
        }
        else if (direction == "bakåt")
        {
            Console.WriteLine();
            currentRoom = "stairs2";
        }
        else
        {
            Console.WriteLine("börjar känna mig korkad");
            Console.WriteLine("bulan på skallen börjar likna en tennisboll");
        }
    }







}


