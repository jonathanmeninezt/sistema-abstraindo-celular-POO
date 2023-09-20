using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
            Console.WriteLine("Celular Nokia: ");
            Nokia nokia = new Nokia("123456", "Nokia 3310", "IMEI123", 16);
            nokia.Ligar();
            // Instalar um aplicativo no Nokia
            nokia.InstalarAplicativo("Banco Pan");

            Console.WriteLine("\n");

            Console.WriteLine("Celular Iphone: ");
            Iphone iphone = new Iphone("1458", "AP-15", "IMEI256", 264);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
