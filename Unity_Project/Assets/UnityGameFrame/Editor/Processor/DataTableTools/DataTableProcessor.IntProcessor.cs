﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2019 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

using System.IO;

namespace UnityGameFrame.Editor.Processor
{
    public sealed partial class DataTableProcessor
    {
        private sealed class IntProcessor : GenericDataProcessor<int>
        {
            public override bool IsSystem
            {
                get
                {
                    return true;
                }
            }

            public override string LanguageKeyword
            {
                get
                {
                    return "int";
                }
            }

            public override string[] GetTypeStrings()
            {
                return new string[]
                {
                    "int",
                    "int32",
                    "system.int32"
                };
            }

            public override int Parse(string value)
            {
                return int.Parse(value);
            }

            public override void WriteToStream(BinaryWriter stream, string value)
            {
                stream.Write(Parse(value));
            }
        }
    }
}
