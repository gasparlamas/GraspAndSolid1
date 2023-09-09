namespace Full_GRASP_And_SOLID.Library
{
    public class ProductionCost
    {
        public Step[] Recipe { get; set; }

        public ProductionCost()
        {
            Recipe = new Step[0]; 
        }

        public double GetProductionCost()
        //Este metodo se encarga de calcular el costo de produccion, por lo que la clase ProductionCost
        //tiene la única responsabilidad de realiza este cálculo.
        //Se aplica el principio SRP, lo que permite que las clases esten ordenadas y cumplan una única responsabilidad.
        {
            double InputsCost = 0;
            double EquipmentsCost = 0;

            foreach (Step step in Recipe)
            {
                InputsCost += step.Input.UnitCost * step.Quantity;
                EquipmentsCost += step.Time * step.Equipment.HourlyCost;
            }

            double CostoTotal =  InputsCost + EquipmentsCost;

            return CostoTotal;
        }
    }
}
