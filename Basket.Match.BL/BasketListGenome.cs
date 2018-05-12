using System;
using Basket.Common.Data;

namespace Basket.Match.BL
{
    public class BasketListGenome : ListGenomes
    {
        #region Data Members

        private double[] m_weights;
        private BasketDTO m_basket;

        #endregion

        #region Properties

        public double[] Weights
        {
            get { return m_weights; }
            private set { m_weights = value; }
        }

        // TODO: Return here a matrix containing the values of the basket's items
        public BasketDTO Basket
        {
            get
            {
               
                return m_basket;
            }
            //set { m_basket = value; }
        }

        #endregion

        #region CTOR

        public BasketListGenome(int length) : base(length, 0, 1)
        {
            this.m_weights = new double[length];
            this.m_weights[0] = 1;

            // Default weights
            for (int i = 1; i < m_weights.Length; i++)
            {
                this.m_weights[i] = 0;
            }
        }

        #endregion

        #region Public Methods

        public void SetWeights(float[] weights)
        {
            this.m_weights = new double[weights.Length];

            for (int i = 0; i < weights.Length; i++)
            {
                SetWeight(weights[i], i);
            }
        }

        public void SetWeight(float weight, int valNum)
        {
            if (weight > 1 || weight < 0)
            {
                throw new Exception("the weight must be between 1 and 0");
            }

            this.m_weights[valNum] = weight; 
        }

        public override double FitnessFunction()
        {
            double productToReturn = 1f;
            for (int i = 0; i < this.Length; i++)
            {
                // TODO: Compare those genes against IdialBaskets in Population class
                // to find the minimum
                productToReturn *= (this.m_weights[i] * (double)this.m_list[i]);
            } 

            return productToReturn;
        }

        #endregion
    }
}
