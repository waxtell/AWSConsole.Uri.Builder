﻿namespace AWSConsole.Uri.Builder.CloudWatchLogs
{
    public interface ILogOptions
    {
        /// <summary>
        /// Restrict filters, etc. to the provided log group.
        /// </summary>
        /// <param name="logGroup">Searches, etc. will apply exclusively to this log group.</param>
        /// <returns>An ILogGroupOptions which will allow for additional specificity.</returns>
        ILogGroupOptions WithLogGroup(string logGroup);

        /// <summary>
        /// Search for log groups that match the provided name filter.  Please see https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/FilterAndPatternSyntax.html for filter and pattern syntax.
        /// </summary>
        /// <param name="logGroupNameFilter">Select log groups that match the name filter.</param>
        /// <returns>The only thing left to do now is Build()</returns>
        IBuild WithLogGroupNameFilter(string logGroupNameFilter);

        /// <summary>
        /// Build the URI from the provided parameters.
        /// </summary>
        /// <returns>The CloudWatch Logs URI</returns>
        System.Uri Build();
    }
}