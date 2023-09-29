
////using LessonToday;

//////Employee employee1 = new()
//////{
//////    fullName = "Semed Huseynov",
//////    address = "Ehmedili",
//////    age = 27
//////};


//////Employee employee2 = new()
//////{
//////    fullName = "Oruc Mehrabov",
//////    address = "Yasamal",
//////    age = 26
//////};

//////Employee employee3 = new()
//////{
//////    fullName = "Ilham Abasli",
//////    address = "Lokbatan",
//////    age = 19
//////};


//////Employee[] employees = { employee1, employee2, employee3 };


//////foreach(var item in employees)
//////{
//////    Console.WriteLine(item.GetFullData());
//////}

//////Book book = new Book("Xosrov", "Nizami");


//////book.name = "Isgendername";
//////book.author = "Nizami";

////Book book = new(100, "Azerbaycan");

//////Console.WriteLine(book.GetData());


//using LessonToday;
//using LessonToday.Models;

////User user1 = new User
////{
////    id = 1,
////    fullName = "Aqshin Veliyev",
////    age = 25
////};

////User user2 = new User
////{
////    id = 2,
////    fullName = "Haci Ehmadov",
////    age = 28
////};

////User user3 = new User
////{
////    id = 3,
////    fullName = "Metanet Abbasova",
////    age = 21
////};

////User user4 = new User
////{
////    id = 4,
////    fullName = "Meryem Eliyeva",
////    age = 23
////};

////User[] people = { user1, user2, user3, user4 };

////foreach(var item in people)
////{
////    Console.WriteLine(item.fullName);
////}

////foreach (var item in people)
////{
////    if(item.id == 2)
////    {
////        Console.WriteLine(item.fullName);
////        break;
////    }
////}

////var result = people.Where(m => m.id > 2).ToArray();

////foreach (var item in result)
////{
////    Console.WriteLine(item.fullName);
////}

////var result = Array.FindAll(people, m => m.age > 24 && m.age < 30);

////foreach (var item in result)
////{
////    Console.WriteLine(item.fullName);
////}

////ShowUsers();


////static void ShowUsers()
////{

////    var result = GetAllUser();

////    foreach (var item in result)
////    {
////        Console.WriteLine(item.fullName);
////    }
////}

////static User[] GetAllUser()
////{
////    User user1 = new User
////    {
////        id = 1,
////        fullName = "Aqshin Veliyev",
////        age = 25
////    };

////    User user2 = new User
////    {
////        id = 2,
////        fullName = "Haci Ehmadov",
////        age = 28
////    };

////    User user3 = new User
////    {
////        id = 3,
////        fullName = "Metanet Abbasova",
////        age = 21
////    };

////    User user4 = new User
////    {
////        id = 4,
////        fullName = "Meryem Eliyeva",
////        age = 23
////    };

////    User[] people = { user1, user2, user3, user4 };

////    return people;

////}

////UserService service = new();

////service.ShowUsers();

////User user = service.GetUserById(3);

////Console.WriteLine(user.fullName);

//static void SearchByName(string searchText)
//{
//    Product[] products = GetAllProducts();

//    Product existProduct = products.FirstOrDefault(m => m.name.Trim().ToLower().Contains(searchText));

   

//    if(existProduct == null)
//    {
//        Console.WriteLine("Not Found");
//        return;

//    }

//    Product[] resultProducts = products.Where(m => m.name.Trim().ToLower().Contains(searchText.Trim().ToLower())).ToArray();

//    foreach (var product in resultProducts)
//    {
//        Console.WriteLine($"Id : {product.id} - Name: {product.name} -  Price: {product.price} -  Count: {product.count}");
//    }


//    //foreach (var product in products)
//    //{
//    //    if (product.name.Trim().ToLower().Contains(searchText.Trim().ToLower()))
//    //    {
//    //        Console.WriteLine($"Id : {product.id} - Name: {product.name} -  Price: {product.price} -  Count: {product.count}");
//    //    }
//    //}

//}

//Console.WriteLine("Add search text: ");

//SearchText: string searchText = Console.ReadLine();

//if(searchText == "")
//{
//    Console.WriteLine("Please add search text: ");
//    goto SearchText;
//}

//SearchByName(searchText);

////SearchByName("n");

//static Product[] GetAllProducts()
//{

//    Product product1 = new Product
//    {
//        id = 1,
//        name = "Iphone 13",
//        price = 1200,
//        count = 3
//    };

//    Product product2 = new Product
//    {
//        id = 2,
//        name = "Samsung",
//        price = 2200,
//        count = 5
//    };

//    Product product3 = new Product
//    {
//        id = 3,
//        name = "Xiaomi",
//        price = 200,
//        count = 30
//    };

//    Product product4 = new Product
//    {
//        id = 4,
//        name = "Nokia",
//        price = 1000,
//        count = 100
//    };

//    Product[] products = { product1, product2, product3, product4 };

//    return products;
   
//}