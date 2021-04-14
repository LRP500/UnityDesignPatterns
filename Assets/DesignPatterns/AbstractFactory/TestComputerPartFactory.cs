using UnityEngine;

namespace DesignPatterns.AbstractFactory
{
    public class TestComputerPartFactory : MonoBehaviour
    {
        private void Start()
        {
            IComputerPartFactory factory = new ProcessorFactory();
            var product = factory.CreateComputerPart("AMD Ryzen 7 5800X 3.8GHz");
            Debug.Log(product);

            factory = new PowerSupplyFactory();
            product = factory.CreateComputerPart("SeaSonic PRIME TX 850W Titanium");
            Debug.Log(product);
        }
    }
}
