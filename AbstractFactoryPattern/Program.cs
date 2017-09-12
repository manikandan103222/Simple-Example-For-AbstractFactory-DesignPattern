using System;
namespace AbstractFactory_DesignPattern
{
    //AbstractProduct - Main 
    interface IElectronicProduct
    {
        //Common property
        string Name { get; set; }
        string Memory { get; set; }
        string Description { get; set; }

        //Common Method / Function / Behaviour
        string GetMemory();
        void SetMemory(int value);
    }

    //AbstractProduct - 1
    interface ILaptop : IElectronicProduct
    {
        string WarrantyPeriod { get; set; }
        string ModelDetails { get; set; }
    }

    //AbstractProduct - 2
    interface IMobile : IElectronicProduct
    {
        string WarrantyPeriod { get; set; }
        string ModelDetails { get; set; }
        string PhoneType { get; set; }
    }

    //'AbstractFactory' Interface
    interface IProduct
    {
        ILaptop CreateLaptopProduct(LaptopTypeDetails laptopTypeDetails);
        IMobile CreateMobileProduct(MobileTypeDetails mobileTypeDetails);
    }

    //'Product-1' For Laptop
    class GamingLaptop : ILaptop
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _memory;
        public string Memory
        {
            get { return _memory; }
            set { _memory = value; }
        }

        public string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string _WarrantyPeriod;
        public string WarrantyPeriod
        {
            get { return _WarrantyPeriod; }
            set { _WarrantyPeriod = value; }
        }

        public string _modelDetails;
        public string ModelDetails
        {
            get { return _modelDetails; }
            set { _modelDetails = value; }
        }

        public string GetMemory()
        {
            return Memory;
        }

        public void SetMemory(int value)
        {
            Memory = string.Format("{0} {1}", value, "TB");
        }

        public GamingLaptop()
        {
            Name = "HP Omen";
            Memory = "1 TB";
            Description = "It's famous Gaming laptop in india";
            WarrantyPeriod = "1 Year";
            ModelDetails = "HP OMEN Core i5 7th Gen -(16 GB / 1 TB HDD/ 128 GB SSD/ Windows 10 Home / 4 GB Graphics) 15 - ax249TX Gaming Laptop  (15.6 inch, Black)";
        }
    }

    //'Product-2' For Laptop
    class NormalLaptop : ILaptop
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _memory;
        public string Memory
        {
            get { return _memory; }
            set { _memory = value; }
        }

        public string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string _WarrantyPeriod;
        public string WarrantyPeriod
        {
            get { return _WarrantyPeriod; }
            set { _WarrantyPeriod = value; }
        }

        public string _modelDetails;
        public string ModelDetails
        {
            get { return _modelDetails; }
            set { _modelDetails = value; }
        }

        public string GetMemory()
        {
            return Memory;
        }

        public void SetMemory(int value)
        {
            Memory = string.Format("{0} {1}", value, "TB");
        }
        public NormalLaptop()
        {
            Name = "Dell Inspiration";
            Memory = "2 TB";
            Description = "It's famous Gaming laptop in india";
            WarrantyPeriod = "1.5 Year";
            ModelDetails = "HP OMEN Core i5 7th Gen -(16 GB / 1 TB HDD/ 128 GB SSD/ Windows 10 Home / 4 GB Graphics) 15 - ax249TX Gaming Laptop  (15.6 inch, Black)";
        }
    }

    //'Product-1' For Mobile Phone
    class SmartPhone : IMobile
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _memory;
        public string Memory
        {
            get { return _memory; }
            set { _memory = value; }
        }

        public string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string _WarrantyPeriod;
        public string WarrantyPeriod
        {
            get { return _WarrantyPeriod; }
            set { _WarrantyPeriod = value; }
        }

        public string _modelDetails;
        public string ModelDetails
        {
            get { return _modelDetails; }
            set { _modelDetails = value; }
        }

        //GSM or CDMA
        public string _phoneType;
        public string PhoneType
        {
            get { return _phoneType; }
            set { _phoneType = value; }
        }

        public string GetMemory()
        {
            return Memory;
        }

        public void SetMemory(int value)
        {
            Memory = string.Format("{0} {1}", value, "GB");
        }
        public SmartPhone()
        {
            Name = "Lenovo Vibe K5 Note";
            Memory = "8 GB";
            Description = "It's famous Smart Phone in india";
            WarrantyPeriod = "2 Year";
            ModelDetails = "Lenovo Vibe K5 Note (Gold, 32 GB)  (3 GB RAM)";
            PhoneType = "GSM";
        }
    }

    //'Product-2' For Mobile Phone
    class NormalPhone : IMobile
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _memory;
        public string Memory
        {
            get { return _memory; }
            set { _memory = value; }
        }

        public string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string _WarrantyPeriod;
        public string WarrantyPeriod
        {
            get { return _WarrantyPeriod; }
            set { _WarrantyPeriod = value; }
        }

        public string _modelDetails;
        public string ModelDetails
        {
            get { return _modelDetails; }
            set { _modelDetails = value; }
        }

        //GSM or CDMA
        public string _phoneType;
        public string PhoneType
        {
            get { return _phoneType; }
            set { _phoneType = value; }
        }

        public string GetMemory()
        {
            return Memory;
        }

        public void SetMemory(int value)
        {
            Memory = string.Format("{0} {1}", value, "MB");
        }
        public NormalPhone()
        {
            Name = "Nokia 1600 ";
            Memory = "256 MB";
            Description = "It's famous Normal Phone in india";
            WarrantyPeriod = "1 Year";
            ModelDetails = "REBOXED Nokia 1600 256 MB Black RAM";
            PhoneType = "CDMA";
        }
    }

    
    //'ConcreteFactory' class
    class ElectronicProduct : IProduct
    {
        //'Maintain ConcreteFactory-1'
        public ILaptop CreateLaptopProduct(LaptopTypeDetails laptopTypeDetails)
        {
            switch(laptopTypeDetails)
            {
                case LaptopTypeDetails.Gaming:
                    return new GamingLaptop();
                case LaptopTypeDetails.Normal:
                    return new NormalLaptop();
                default:
                    throw new ApplicationException((LaptopTypeDetails.Gaming == laptopTypeDetails) ? "Gaming" : "Normal"  + "type can not be created");
            }
        }

        //'Maintain ConcreteFactory-2'
        public IMobile CreateMobileProduct(MobileTypeDetails mobileTypeDetails)
        {
            switch (mobileTypeDetails)
            {
                case MobileTypeDetails.Smart:
                    return new SmartPhone();
                case MobileTypeDetails.Normal:
                    return new NormalPhone();
                default:
                    throw new ApplicationException((MobileTypeDetails.Smart == mobileTypeDetails) ? "Smart" : "Normal" + "type can not be created");
            }
        }

    }

    //'Client' Class
    class Product
    {
        public Product()
        {
            Console.WriteLine("Creating Product Factory");
        }

        //maintain laptop products
        public ILaptop LaptopProduct(IProduct Product, LaptopTypeDetails laptopTypeDetails)
        {
            return Product.CreateLaptopProduct(laptopTypeDetails);
        }

        //maintain mobile products
        public IMobile MobileProduct(IProduct Product, MobileTypeDetails mobileTypeDetails)
        {
            return Product.CreateMobileProduct(mobileTypeDetails);
        }
    }

    //Different product that can be created by the factory
    enum ProductDetails
    {
        MobilePhone,
        Laptop,
        ExternalHardDrive
    }

    enum LaptopTypeDetails
    {
        Gaming,
        Normal
    }

    enum MobileTypeDetails
    {
        Smart,
        Normal
    }

    //main class act as 'Client'
    class Program
    {
        static void Main(string[] args)
        {
            IProduct electronicProduct = new ElectronicProduct();
            Product product = new Product();

            //-------------------------Laptop product----------------------------------------------
            Console.WriteLine("------------------------------------------Laptop Products------------------------------------------");
            foreach (LaptopTypeDetails laptopTypeDetail in Enum.GetValues(typeof(LaptopTypeDetails)))
            {
                var laptopProduct = product.LaptopProduct(electronicProduct, laptopTypeDetail);
                Console.WriteLine("------------------------------------------{0} Laptop------------------------------------------", laptopTypeDetail.ToString());
                Console.WriteLine("Name: {0}, Memory: {1}, Description: {2}, Available Memory: {3}, Contract Period: {4}, Model Details: {5} "
                    , laptopProduct.Name, laptopProduct.Memory, laptopProduct.Description, laptopProduct.GetMemory(), laptopProduct.WarrantyPeriod
                    , laptopProduct.ModelDetails);
                Console.WriteLine("Do you want to reset {0} memory?", laptopProduct.Name);
                Console.Write("Press 1 to reset memory: ");
                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    Console.Write("Enter Memory Capacity: ");
                    laptopProduct.SetMemory(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Current Reset Memory Value: {0}", laptopProduct.GetMemory());
                }
            }

            //-------------------------Mobile product----------------------------------------------
            Console.WriteLine("------------------------------------------Mobile Phone Products------------------------------------------");
            foreach (MobileTypeDetails mobileTypeDetail in Enum.GetValues(typeof(MobileTypeDetails)))
            {
                var mobileProduct = product.MobileProduct(electronicProduct, mobileTypeDetail);
                Console.WriteLine("------------------------------------------{0} Phone------------------------------------------", mobileTypeDetail.ToString());
                Console.WriteLine("Name: {0}, Memory: {1}, Description: {2}, Available Memory: {3}, Contract Period: {4}, Model Details: {5}, Phone Type: {6} "
                    , mobileProduct.Name, mobileProduct.Memory, mobileProduct.Description, mobileProduct.GetMemory(), mobileProduct.WarrantyPeriod
                    , mobileProduct.ModelDetails, mobileProduct.PhoneType);
                Console.WriteLine("Do you want to reset {0} memory?", mobileProduct.Name);
                Console.Write("Press 1 to reset memory: ");
                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    Console.Write("Enter Memory Capacity: ");
                    mobileProduct.SetMemory(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Current Reset Memory Value: {0}", mobileProduct.GetMemory());
                }
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
