﻿using System;
using System.Collections.Generic;
using System.Text;

namespace common
{
    public class Population
    {
        #region Data Members

        // Basic Params
        private int m_length;
        private int m_crossoverPoint;
        private int m_initialPopulationCount;
        private int m_populationLimit;
        private float m_mutationFreq;
        private float m_deathParam;
        private float m_reproduceParam;
        private int m_currentGeneration = 1;

        // Initial populaitons
        private List<BasketListGenome> m_genomes;
        private List<BasketListGenome> m_genomesResults;
        private List<BasketListGenome> m_genomesNextGen;
        private List<BasketListGenome> m_genomeFamily;

        #endregion

        #region Properties



        #endregion

        #region CTOR

        public Population(
            int length, 
            int crossOverPoint, 
            int initialPop, 
            int popLimit, 
            float mutationFreq, 
            float deathParam, 
            float reproductionParam,
            float[] weights)
        {
            this.m_length = length;
            this.m_crossoverPoint = crossOverPoint;
            this.m_initialPopulationCount = initialPop;
            this.m_populationLimit = popLimit;
            this.m_mutationFreq = mutationFreq;
            this.m_deathParam = deathParam;
            this.m_reproduceParam = reproductionParam;

            this.m_genomes = new List<BasketListGenome>();

            for (int i = 0; i < this.m_initialPopulationCount; i++)
            {
                BasketListGenome newGenome = new BasketListGenome(this.m_length);
                newGenome.CrossoverPoint = this.m_crossoverPoint;
                newGenome.FitnessFunction();
                newGenome.SetWeights(weights);

                this.m_genomes.Add(newGenome);
            }
        }

        #endregion

        #region Private Methods

        private void Mutate(Genome g)
        {
            if (ListGenomes.Seed.NextDouble() < this.m_mutationFreq)
            {
                g.Mutate();
            }
        }

        #endregion

        #region Public Methods

        

        #endregion
    }
}