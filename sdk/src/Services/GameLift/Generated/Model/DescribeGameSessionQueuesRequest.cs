/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeGameSessionQueues operation.
    /// Retrieves the properties for one or more game session queues. When requesting multiple
    /// queues, use the pagination parameters to retrieve results as a set of sequential pages.
    /// If successful, a <a>GameSessionQueue</a> object is returned for each requested queue.
    /// When specifying a list of queues, objects are returned only for queues that currently
    /// exist in the region.
    /// 
    ///  
    /// <para>
    /// Queue-related operations include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateGameSessionQueue</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeGameSessionQueues</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateGameSessionQueue</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteGameSessionQueue</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeGameSessionQueuesRequest : AmazonGameLiftRequest
    {
        private int? _limit;
        private List<string> _names = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Maximum number of results to return. Use this parameter with <code>NextToken</code>
        /// to get results as a set of sequential pages.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        /// List of queue names to retrieve information for. To request settings for all queues,
        /// leave this parameter empty.
        /// </para>
        /// </summary>
        public List<string> Names
        {
            get { return this._names; }
            set { this._names = value; }
        }

        // Check to see if Names property is set
        internal bool IsSetNames()
        {
            return this._names != null && this._names.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token that indicates the start of the next sequential page of results. Use the token
        /// that is returned with a previous call to this action. To specify the start of the
        /// result set, do not specify a value.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}