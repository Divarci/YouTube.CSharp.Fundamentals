//EVENT 

// 1000 products you are selling. cell phone(+), hard drive(-), usb memory(+), lcd monitor(-)


using YouTube.CSharp.Events;

Product Hdd = new Product(120);
Hdd.Name = "Hard Disk";
Hdd.ProductControllerEvent += Hdd_ProductControllerEvent;



Product cellPhone = new Product(50);
cellPhone.Name = "Cell Phone";
cellPhone.ProductControllerEvent += CellPhone_ProductControllerEvent;



Product usbMem = new Product(100);
usbMem.Name = "Usb Memory";
usbMem.ProductControllerEvent += UsbMem_ProductControllerEvent;



Product lcdMonitor = new Product(50);
lcdMonitor.Name = "Lcd Monitor";


for (int i = 0; i < 15; i++)
{
    Hdd.Sell(10);
    cellPhone.Sell(10);
    usbMem.Sell(10);
    lcdMonitor.Sell(10);

    Console.WriteLine(Hdd.Name+":"+Hdd.Stock);
    Console.WriteLine(cellPhone.Name + ":"+cellPhone.Stock);
    Console.WriteLine(usbMem.Name + ":"+usbMem.Stock);
    Console.WriteLine(lcdMonitor.Name + ":"+lcdMonitor.Stock);

    Console.ReadLine();
}

void CellPhone_ProductControllerEvent()
{
    Console.WriteLine($"{cellPhone.Name} is about to finish");
}

void UsbMem_ProductControllerEvent()
{
    Console.WriteLine($"{usbMem.Name} is about to finish");
}

void Hdd_ProductControllerEvent()
{
    Console.WriteLine($"{Hdd.Name} is about to finish");
}