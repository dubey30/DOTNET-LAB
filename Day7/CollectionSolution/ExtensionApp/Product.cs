namespace Catalog;
public class Product
{
    private int Id;
    private string title;
    private string imageURL;
    private string category;
    private string description;
    private float  unitPrice;
    private int balance;
    private string paymentTerm;
    private string delivery;

    public Product(int productId, string title, string brand, string category)
    {
        this.Id = productId;
        this.title = title;
        this.category = category;
        this.unitPrice = unitPrice;
        this.balance = balance;
    }
    public Product ( int productId, string title, string brand, string category, float unitPrice,int balance, string description, string imageURL)
    {
        this.Id=productId;
        this.title= title;
        this.category= category;
        this.unitPrice = unitPrice;
        this.balance = balance;
        this.description = description;
        this.imageURL = imageURL;
    }

    public int productId
    {
        get{return Id;}
        set { title = value;}
    }
    public string category{
        get{return category;}
        set{ category = value;}
    }
        public string paymentTerm{
            get{return paymentTerm;}
            set{paymentTerm = value;}

        }

        public string delivery{
            get{return delivery;}
            set{delivery = value;}
        }
        public string imageURL
        {
            get{return imageURL;}
            set{imageURL = value;}
        }
        public float unitPrice{
            get{return unitPrice;}
            set{ unitPrice = value;}
        }

        public int balance
        {
            get{return balance;}
            set{ balance = value;}
        }
    }
