using NeuralNetworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem
{
    public class SystemController
    {
        public NeuralNetwork DataNetwork { get; }

        public NeuralNetwork TestDataNetwork { get; }
        public SystemController()
        {
            var testDataTopology = new Topology(4, 1, 0.1, 2);
            TestDataNetwork = new NeuralNetwork(testDataTopology);

            var dataTopology = new Topology(14, 1, 0.1, 7);
            DataNetwork = new NeuralNetwork(dataTopology);
        }
    }
}
