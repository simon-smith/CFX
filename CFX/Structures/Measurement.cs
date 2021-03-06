﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures
{
    /// <summary>
    /// Abstract base class for dynamic data structure which describes a measurement that was made by a human
    /// or by automated equipment in the course of inspecting or testing a production unit
    /// </summary>
    abstract public class Measurement
    {
        public Measurement()
        {
            UniqueIdentifier = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// A unique identifier that for this particular measurement instance
        /// (new and unique each time a new measurement is made or repeated).
        /// </summary>
        public string UniqueIdentifier
        {
            get;
            set;
        }

        /// <summary>
        /// A name that uniquely describes the test or measurement that was performed.
        /// </summary>
        public virtual string MeasurementName
        {
            get;
            set;
        }

        /// <summary>
        /// The date/time when this Measurement was recorded (if known, otherwise null)
        /// </summary>
        public DateTime? TimeRecorded
        {
            get;
            set;
        }

        /// <summary>
        /// An optional positive integer describing the sequence in which the tests or measurements were performed
        /// that resulted in this Reading.
        /// /// </summary>
        public int Sequence
        {
            get;
            set;
        }

        /// <summary>
        /// An enumeration indicating whether or not this measurement is considered acceptable.
        /// </summary>
        public TestResult Result
        {
            get;
            set;
        }

        /// <summary>
        /// An optional list of components (instance of a part) on a production unit(s) to be associated with this measurement.
        /// </summary>
        public List<ComponentDesignator> Components
        {
            get;
            set;
        }
    }
}
