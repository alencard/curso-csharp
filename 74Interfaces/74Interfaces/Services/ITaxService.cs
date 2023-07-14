namespace _74Interfaces.Services
{
    // se eu criasse um tipo de taxa para cada país, todos poderiam ser adicionados como filho, entao usando o ITaxService eu poderia usar qualquer taxa facilmente
    internal interface ITaxService
    {
        double Tax(double amount);
    }
}
