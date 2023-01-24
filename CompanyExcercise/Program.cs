using CompanyExcercise;

internal class Program
{
    private static void Main(string[] args)
    {
        Company company = new Company("Company1", "Address 123", "12312312345", 20000, 10000);
        Company company1 = new Company("Company2", "Address 456", "7659876543", 148621, 7486);
        Company company2 = new Company("Company3", "Address 12384", "7463548947", 7453240, 745374);
        Company company3 = new Company(company1);
    }
}