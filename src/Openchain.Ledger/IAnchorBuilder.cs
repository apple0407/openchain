﻿// Copyright 2015 Coinprism, Inc.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Threading.Tasks;

namespace Openchain.Ledger
{
    /// <summary>
    /// Provides functionality for creating a database anchor.
    /// </summary>
    public interface IAnchorBuilder
    {
        Task Initialize();

        /// <summary>
        /// Creates a database anchor for the current state of the database.
        /// </summary>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<LedgerAnchor> CreateAnchor(IStorageEngine storageEngine);

        /// <summary>
        /// Marks the anchor as successfully recorded in the anchoring medium.
        /// </summary>
        /// <param name="anchor">The anchor to commit.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task CommitAnchor(LedgerAnchor anchor);
    }
}
