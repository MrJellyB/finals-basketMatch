using System;
using System.Collections.Generic;

namespace common
{
    public class ListGenomes : Genome
    {

        #region Data Members

        private Random m_seed;
        public Random Seed
        {
            get { return m_seed;}
            set { m_seed = value;}
        }
        
        private int m_min;
        public int Min
        {
            get { return m_min;}
            set { m_min = value;}
        }
        
        private int m_max;
        public int Max
        {
            get { return m_max;}
            set { m_max = value;}
        }
        
        private List<object> m_list;
        public List<object> List
        {
            get { return m_list;}
            set { m_list = value;}
        }
        

        #endregion

        #region CTOR

        public ListGenomes()
        {

        }

        public ListGenomes(long length, int min, int max) 
        {
            this.Length = length;
            this.Min = min;
            this.Max = max;
            this.m_list = new List<object>();

            // Generate the gene list
            for (int i = 0; i < length; i++)
            {
                int nextVal = GenerateRandGeneVal(min,max);
                this.m_list.Add(nextVal);
            }
        }
        public ListGenomes(Genome g, int min, int max) 
        {
            this.Length = ((ListGenomes)g).List.Count;
            this.Min = min;
            this.Max = max;
            this.m_list = ((ListGenomes)g).List;
        }

        private int GenerateRandGeneVal(int min, int max)
        {
            return this.m_seed.Next(min, max);
        }

        #endregion

        #region Private Methods

        // Exchanges gene values between two genes according to the CrossingPoint
        private void CrossoverGeneValues(ref ListGenomes geneOne, ref ListGenomes geneTwo)
        {
            for (int i = 0; i < this.CrossoverPoint; i++)
            {
                geneOne.List[i] = geneTwo.List[i];
            }

            for (int i = this.CrossoverPoint; i < Length; i++)
            {
                geneTwo.List[i] = geneOne.List[i];
            }
        }

        #endregion

        #region Public Methods

        public override Genome Crossover(Genome g)
        {
            // Generate the firstGene as copy of g and the second one as copy of this genome
            ListGenomes originalGenome = (ListGenomes)g;
            ListGenomes firstGene = new ListGenomes(g, originalGenome.Min, originalGenome.Max);
            ListGenomes secondGene = new ListGenomes((Genome)this, originalGenome.Min, originalGenome.Max);
            
            CrossoverGeneValues(ref firstGene, ref secondGene);

            // Take the better gene that made out from the crossover, randomly
            // TODO: Maybe change this check to fitness check
            if (this.m_seed.Next(2) == 1)
            {
                return firstGene;
            }
            else
            {
                return secondGene;
            }
        }

        public override float FitnessFunction()
        {
            // TODO: Add the fitness function here based on the basket weights
            return 1;
        }

        public override void Initiate()
        {
        }

        /// <summary>
        /// Choose a random gene value and assign a random generated value to it
        /// </summary>
        public override void Mutate()
        {
            this.List[this.Seed.Next((int)this.Length)] = this.Seed.Next(this.Min, this.Max);
        }
        
        public override void CanDie()
        {
            
        }

        public override void CanReproduce()
        {

        }

        #endregion
    }
}
