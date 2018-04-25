using System;

namespace common
{
    public abstract class Genome
    {
        #region Private Data Members
        long m_length;
        int m_crossoverPoint;
        private int m_mutationIndex;
        private float m_currentFitness;
        #endregion

        #region Propeties
        public long Length
        {
            get { return m_length;}
            set { m_length = value;}
        }
        public int MutationIndex
        {
            get { return m_mutationIndex;}
            set { m_mutationIndex = value;}
        }
        public float CurrentFitness
        {
            get { return m_currentFitness;}
            set { m_currentFitness = value;}
        }
        
        public int CrossoverPoint
        {
            get { return m_crossoverPoint;}
            set { m_crossoverPoint = value;}
        }
        #endregion

        #region CTOR DTOR



        #endregion

        #region Public Methods

        public abstract void Initiate();
        public abstract void Mutate();
        public abstract void Crossover(Genome g);
        public abstract float FitnessFunction();

        #endregion
    }
}
