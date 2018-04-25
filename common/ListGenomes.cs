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

            // Generate the gene list
            for (int i = 0; i < length; i++)
            {
                int nextVal = GenerateRandGeneVal(min,max);
                this.m_list.Add(nextVal);
            }
        }

        private int GenerateRandGeneVal(int min, int max)
        {
            return this.m_seed.Next(min, max);
        }

        #endregion

        #region Private Methods

        private void CopyGenes(Genome dest)
        {

        }

        #endregion

        #region Public Methods

        public override void Crossover(Genome g)
        {
            throw new NotImplementedException();
        }

        public override float FitnessFunction()
        {
            throw new NotImplementedException();
        }

        public override void Initiate()
        {
        }

        public override void Mutate()
        {
            throw new NotImplementedException();
        }
        
        #endregion
    }
}
