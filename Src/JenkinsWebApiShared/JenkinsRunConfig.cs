﻿namespace JenkinsWebApi
{
    /// <summary>
    /// Configuration class for JobRunAsync
    /// </summary>
    public class JenkinsRunConfig
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public JenkinsRunConfig()
        {
            this.RunMode = JenkinsRunMode.Ready;
            this.PollingTime = 1000;
            this.StartDelay = 0;
        }

        /// <summary>
        /// Get or set the JenkinsRunMode. The default value is Ready.
        /// </summary>
        public JenkinsRunMode RunMode { get; set;}

        /// <summary>
        /// Status update polling time in milli seconds. The default value is 1 second.
        /// </summary>
        public int PollingTime { get; set; }

        /// <summary>
        /// RunJobAsync start delay in seconds. Defalut value is 0 seconds.
        /// </summary>
        public int StartDelay { get; set; }
    }
}