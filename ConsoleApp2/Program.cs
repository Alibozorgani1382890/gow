
// ایجاد یک حیوان
Animal animal = new Animal
{
    Name = "گاو",
    Type = "دامپروری",
    Gender = "نر",
    MaxAge = 25,
    Age = 1,
    FoodType = "علوفه",
    FoodVolume = 10
};

// ایجاد یک محصول
Product product = new Product
{
    Name = "شیر",
    Unit = "لیتر",
    Price = 10000,
    DailyAmount = 20,
    Disease = "تب برفکی",
    Skin = 100,
    Milk = 500,
    Weight = 500,
    FatWeight = 200,
    DailyWaste = 10
};

// محاسبه درآمد
Income income = new Income
{
    ProductIncome = product.Price * product.DailyAmount,
    WasteIncome = product.DailyWaste * 1000,
    MeatIncome = animal.Weight * 100000,
    DailyCost = 10000,
   
};

// چاپ درآمد
Console.WriteLine("درآمد روزانه: {0}", income.DailyProfit);

// تخمین آورده مالی تا آخر عمر
income.FinancialEstimate = income.DailyProfit * 365 * animal.MaxAge;

// چاپ آورده مالی
Console.WriteLine("آورده مالی تا آخر عمر: {0}", income.FinancialEstimate);

// محاسبه سود گاوداری در n سال آینده
income.ProfitInNYears = income.DailyProfit * 365 ;

// چاپ سود گاوداری
Console.WriteLine("سود گاوداری در n سال آینده: {0}", income.ProfitInNYears);