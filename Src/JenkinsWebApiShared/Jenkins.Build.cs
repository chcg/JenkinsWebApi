﻿using JenkinsWebApi.Internal;
using JenkinsWebApi.Model;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace JenkinsWebApi
{
    public sealed partial class Jenkins
    {

        /// <summary>
        /// Get the Jenkins build data.
        /// </summary>
        /// <param name="jobName">Name of the Jenkins job</param>
        /// <param name="buildNum">Number of the Jenkins build</param>
        /// <returns>Jenkins build data</returns>
        public async Task<JenkinsModelRun> GetBuildAsync(string jobName, int buildNum)
        {
            return await GetBuildAsync(jobName, buildNum, CancellationToken.None);
        }

        /// <summary>
        /// Get the Jenkins build data.
        /// </summary>
        /// <param name="jobName">Name of the Jenkins job</param>
        /// <param name="buildNum">Number of the Jenkins build</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Jenkins build data</returns>
        public async Task<JenkinsModelRun> GetBuildAsync(string jobName, int buildNum, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(jobName))
            {
                throw new ArgumentException(nameof(jobName));
            }

            string str = await GetApiStringAsync($"job/{jobName}/{buildNum}", cancellationToken);
            JenkinsModelRun build = JenkinsDeserializer.DeserializeBuild<JenkinsModelRun>(str);
            return build;
        }

        /// <summary>
        /// Get the Jenkins build data.
        /// </summary>
        /// <param name="jobName">Name of the Jenkins job</param>
        /// <param name="buildNum">Number of the Jenkins build</param>
        /// <returns>Jenkins build data</returns>
        public async Task<T> GetBuildAsync<T>(string jobName, int buildNum) where T : JenkinsModelRun
        {
            return await GetBuildAsync<T>(jobName, buildNum, CancellationToken.None);
        }

        /// <summary>
        /// Get the Jenkins build data.
        /// </summary>
        /// <param name="jobName">Name of the Jenkins job</param>
        /// <param name="buildNum">Number of the Jenkins build</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Jenkins build data</returns>
        public async Task<T> GetBuildAsync<T>(string jobName, int buildNum, CancellationToken cancellationToken) where T : JenkinsModelRun
        {
            if (string.IsNullOrEmpty(jobName))
            {
                throw new ArgumentException(nameof(jobName));
            }

            string str = await GetApiStringAsync($"job/{jobName}/{buildNum}", cancellationToken);
            T build = JenkinsDeserializer.DeserializeBuild<T>(str);
            return build;
        }

        /// <summary>
        /// Get the last build
        /// </summary>
        /// <param name="jobName">Name of the Jenkins job</param>
        /// <returns>Jenkins build data</returns>
        public async Task<JenkinsModelRun> GetLastBuildAsync(string jobName)
        {
            return await GetLastBuildAsync(jobName, CancellationToken.None);
        }

        /// <summary>
        /// Get the last build
        /// </summary>
        /// <param name="jobName">Name of the Jenkins job</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Jenkins build data</returns>
        public async Task<JenkinsModelRun> GetLastBuildAsync(string jobName, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(jobName))
            {
                throw new ArgumentException(nameof(jobName));
            }

            string str = await GetApiStringAsync($"job/{jobName}/lastBuild", cancellationToken);
            JenkinsModelRun build = JenkinsDeserializer.DeserializeBuild<JenkinsModelRun>(str);
            return build;
        }

        /// <summary>
        /// Get the last build
        /// </summary>
        /// <param name="jobName">Name of the Jenkins job</param>
        /// <returns>Jenkins build data</returns>
        public async Task<T> GetLastBuildAsync<T>(string jobName) where T : JenkinsModelRun
        {
            return await GetLastBuildAsync<T>(jobName, CancellationToken.None);
        }

        /// <summary>
        /// Get the last build
        /// </summary>
        /// <param name="jobName">Name of the Jenkins job</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Jenkins build data</returns>
        public async Task<T> GetLastBuildAsync<T>(string jobName, CancellationToken cancellationToken) where T : JenkinsModelRun
        {
            if (string.IsNullOrEmpty(jobName))
            {
                throw new ArgumentException(nameof(jobName));
            }

            string str = await GetApiStringAsync($"job/{jobName}/lastBuild", cancellationToken);
            T build = JenkinsDeserializer.DeserializeBuild<T>(str);
            return build;
        }

    }
}
