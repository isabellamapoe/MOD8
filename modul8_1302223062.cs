using System;

class BankTransferConfig
{

    public string lang { get; set; }
    public int transfer { get; set; }
    
    

     public void bahasa()
    {
        lang = lang == "EN" ? "ID" : "EN";
    }

    public void trans()
    {

    }




















}


class Program
{
    static void Main(string[] args)
    {
        


        BankTransferConfig config = new BankTransferConfig();
        config.bahasa(); 


        if (config.lang == "EN")
        {
            Console.WriteLine("Please insert the amount of money to transfer : ");
        }
        else if (config.lang = "ID")
        {
            Console.WriteLine("masukan jumlah uang yang akan di-transfer : ");
        }
        int jumlah_uang = Convert.ToInt32(Console.ReadLine());


        config.() 
        
        // if (config.transfer == "EN")
        // {
        //     Console.WriteLine("Please insert the amount of money to transfer : ");
        // }
        // else if (config.transfer = "ID")
        // {
        //     Console.WriteLine("masukan jumlah uang yang akan di-transfer : ");
        // }



         if (config.lang == "EN")
        {
            Console.WriteLine("select transfer method : ");
        }
        else if (config.lang = "ID")
        {
            Console.WriteLine("pilih metode transfer : ");
        }
        
        if (config.lang == "EN")
        {
            Console.WriteLine("please type <CONFIG6> to confirm the transaction : ");
        }
        else if (config.lang = "ID")
        {
            Console.WriteLine("Ketik <CONFIG7> untuk mengkonfirmasi transaksi : ");
        }
        
        string confirm = Console.ReadLine();

        if (config.lang == "EN" && confirm == <CONFIG6>)
        {
            Console.WriteLine(" transfer is complete");
        }
        else if (config.lang == "ID" && confirm == <CONFIG7>)
        {
            Console.WriteLine(" transaksi berhasil ");
        }
        

    }
    
}