﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indy.IL2CPU.Assembler.X86 {
	[OpCode(0xFFFFFFFF, "cmp")]
	public class Compare: Instruction {
		public readonly string Address1;
		public readonly string Address2;
        public readonly string Size = "";

        public Compare(string aAddress1, string aAddress2) {
            Address1 = aAddress1;
            Address2 = aAddress2;
        }

        public Compare(string aSize, string aAddress1, string aAddress2) {
            Size = aSize;
            Address1 = aAddress1;
            Address2 = aAddress2;
        }

        public Compare(string aAddress1, UInt32 aAddress2) {
            Address1 = aAddress1;
            Address2 = aAddress2.ToString();
        }

        public Compare(string aSize, string aAddress1, UInt32 aAddress2) {
            Size = aSize;
            Address1 = aAddress1;
            Address2 = aAddress2.ToString();
        }

        public override string ToString() {
			return "cmp " + Size + " " + Address1 + "," + Address2;
		}
	}
}