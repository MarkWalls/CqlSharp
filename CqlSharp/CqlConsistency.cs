// CqlSharp
// Copyright (c) 2013 Joost Reuzel
//  
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//  
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace CqlSharp
{
    /// <summary>
    ///   Cql Consistency 'levels'
    /// </summary>
    public enum CqlConsistency : short
    {
        Any = 0x0000,

        One = 0x0001,

        Two = 0x0002,

        Three = 0x0003,

        Quorum = 0x0004,

        All = 0x0005,

        LocalQuorum = 0x0006,

        EachQuorum = 0x0007,
    }
}