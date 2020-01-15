namespace EjemploAdaptador
{
    class ConvertidorDecimal : IConvertidorDecimal
    {
        private readonly IGeneradorEnteroComoString origen;

        public ConvertidorDecimal(IGeneradorEnteroComoString origen)
        {
            this.origen = origen;
        }

        public decimal ConvertirADecimal()
        {
            decimal v;
            if (decimal.TryParse(origen.GenerarEnteroComoString(), out v))
                return v;
            return 0m;
        }
    }
}
