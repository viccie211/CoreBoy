using System;
using System.Collections.Generic;

namespace CoreBoy
{
    public partial class CPU
    {
        #region Properties

        public Dictionary<byte, string> NonPrefixedInstructions = new Dictionary<byte, string>()
        {
            #region LD
            #region LD_D8
            {
                0x06, OpcodeNames.LD_B_D8
            },
            {
                0x0E, OpcodeNames.LD_C_D8
            },
            {
                0x16, OpcodeNames.LD_D_D8
            },
            {
                0x1E, OpcodeNames.LD_E_D8
            },
            {
                0x26, OpcodeNames.LD_H_D8
            },
            {
                0x2E, OpcodeNames.LD_L_D8
            },
            {
                0x36, OpcodeNames.LD_HL_D8
            },
            {
                0x3E, OpcodeNames.LD_A_D8
            },
            #endregion

    	    #region LD_B
            {
                0x40,OpcodeNames.LD_B_B
            },
            {
                0x41,OpcodeNames.LD_B_C
            },
            {
                0x42,OpcodeNames.LD_B_D
            },
            {
                0x43,OpcodeNames.LD_B_E
            },
            {
                0x44,OpcodeNames.LD_B_H
            },
            {
                0x45,OpcodeNames.LD_B_L
            },
            {
                0x46,OpcodeNames.LD_B_HL
            },
            {
                0x47,OpcodeNames.LD_B_A
            },
            #endregion

            #region LD_C
            {
                0x48,OpcodeNames.LD_C_B
            },
            {
                0x49,OpcodeNames.LD_C_C
            },
            {
                0x4A,OpcodeNames.LD_C_D
            },
            {
                0x4B,OpcodeNames.LD_C_E
            },
            {
                0x4C,OpcodeNames.LD_C_H
            },
            {
                0x4D,OpcodeNames.LD_C_L
            },
            {
                0x4E,OpcodeNames.LD_C_HL
            },
            {
                0x4F,OpcodeNames.LD_C_A
            },
            #endregion

            #region LD_D
            {
                0x50,OpcodeNames.LD_D_B
            },
            {
                0x51,OpcodeNames.LD_D_C
            },
            {
                0x52,OpcodeNames.LD_D_D
            },
            {
                0x53,OpcodeNames.LD_D_E
            },
            {
                0x54,OpcodeNames.LD_D_H
            },
            {
                0x55,OpcodeNames.LD_D_L
            },
            {
                0x56,OpcodeNames.LD_D_HL
            },
            {
                0x57,OpcodeNames.LD_D_A
            },
            #endregion

            #region LD_E
            {
                0x58,OpcodeNames.LD_E_B
            },
            {
                0x59,OpcodeNames.LD_E_C
            },
            {
                0x5A,OpcodeNames.LD_E_D
            },
            {
                0x5B,OpcodeNames.LD_E_E
            },
            {
                0x5C,OpcodeNames.LD_E_H
            },
            {
                0x5D,OpcodeNames.LD_E_L
            },
            {
                0x5E,OpcodeNames.LD_E_HL
            },
            {
                0x5F,OpcodeNames.LD_E_A
            },
            #endregion

            #region LD_H
            {
                0x60,OpcodeNames.LD_H_B
            },
            {
                0x61,OpcodeNames.LD_H_C
            },
            {
                0x62,OpcodeNames.LD_H_D
            },
            {
                0x63,OpcodeNames.LD_H_E
            },
            {
                0x64,OpcodeNames.LD_H_H
            },
            {
                0x65,OpcodeNames.LD_H_L
            },
            {
                0x66,OpcodeNames.LD_H_HL
            },
            {
                0x67,OpcodeNames.LD_H_A
            },
            #endregion

            #region LD_L
            {
                0x68,OpcodeNames.LD_L_B
            },
            {
                0x69,OpcodeNames.LD_L_C
            },
            {
                0x6A,OpcodeNames.LD_L_D
            },
            {
                0x6B,OpcodeNames.LD_L_E
            },
            {
                0x6C,OpcodeNames.LD_L_H
            },
            {
                0x6D,OpcodeNames.LD_L_L
            },
            {
                0x6E,OpcodeNames.LD_L_HL
            },
            {
                0x6F,OpcodeNames.LD_L_A
            },
            #endregion

            #region LD_HL
            {
                0x70,OpcodeNames.LD_HL_B
            },
            {
                0x71,OpcodeNames.LD_HL_C
            },
            {
                0x72,OpcodeNames.LD_HL_D
            },
            {
                0x73,OpcodeNames.LD_HL_E
            },
            {
                0x74,OpcodeNames.LD_HL_H
            },
            {
                0x75,OpcodeNames.LD_HL_L
            },
            {
                0x77,OpcodeNames.LD_HL_A
            },
            #endregion

            #region LD_A
            {
                0x78,OpcodeNames.LD_A_B
            },
            {
                0x79,OpcodeNames.LD_A_C
            },
            {
                0x7A,OpcodeNames.LD_A_D
            },
            {
                0x7B,OpcodeNames.LD_A_E
            },
            {
                0x7C,OpcodeNames.LD_A_H
            },
            {
                0x7D,OpcodeNames.LD_A_L
            },
            {
                0x7E,OpcodeNames.LD_A_HL
            },
            {
                0x7F,OpcodeNames.LD_A_A
            },
            #endregion
            #endregion            
            
            #region ADD
            {
                0x80, OpcodeNames.ADD_A_B
            },
            {
                0x81, OpcodeNames.ADD_A_C
            },
            {
                0x82, OpcodeNames.ADD_A_D
            },
            {
                0x83, OpcodeNames.ADD_A_E
            },
            {
                0x84, OpcodeNames.ADD_A_H
            },
            #endregion

            #region JP
            {
                0xC2, OpcodeNames.JP_NZ
            },
            {
                0xC3, OpcodeNames.JP
            },
            {
                0xCA, OpcodeNames.JP_Z
            },
            {
                0xD2, OpcodeNames.JP_NC
            },
            {
                0xDA, OpcodeNames.JP_C
            }
            #endregion
        };

        public Dictionary<byte, string> PrefixedInstructions = new Dictionary<byte, string>()
        {

        };
        public Dictionary<string, Action<CPU>> InstructionSet = new Dictionary<string, Action<CPU>>()
        {
#region LD_D8
            {
                OpcodeNames.LD_B_D8,LD_B_D8
            },
            {
                OpcodeNames.LD_C_D8,LD_C_D8
            },
            {
                OpcodeNames.LD_D_D8,LD_D_D8
            },
            {
                OpcodeNames.LD_E_D8,LD_E_D8
            },
            {
                OpcodeNames.LD_H_D8,LD_H_D8
            },
            {
                OpcodeNames.LD_L_D8,LD_L_D8
            },
            {
                OpcodeNames.LD_HL_D8,LD_HL_D8
            },
            {
                OpcodeNames.LD_A_D8,LD_A_D8
            },
            #endregion
            #region LD_B
            {
                OpcodeNames.LD_B_B,LD_B_B
            },
            {
                OpcodeNames.LD_B_C,LD_B_C
            },
            {
                OpcodeNames.LD_B_D,LD_B_D
            },
            {
                OpcodeNames.LD_B_E,LD_B_E
            },
            {
                OpcodeNames.LD_B_H,LD_B_H
            },
            {
                OpcodeNames.LD_B_L,LD_B_L
            },
            {
                OpcodeNames.LD_B_HL,LD_B_HL
            },
            {
                OpcodeNames.LD_B_A,LD_B_A
            },
            #endregion
            #region LD_C
            {
                OpcodeNames.LD_C_B,LD_C_B
            },
            {
                OpcodeNames.LD_C_C,LD_C_C
            },
            {
                OpcodeNames.LD_C_D,LD_C_D
            },
            {
                OpcodeNames.LD_C_E,LD_C_E
            },
            {
                OpcodeNames.LD_C_H,LD_C_H
            },
            {
                OpcodeNames.LD_C_L,LD_C_L
            },
            {
                OpcodeNames.LD_C_HL,LD_C_HL
            },
            {
                OpcodeNames.LD_C_A,LD_C_A
            },
            #endregion
            #region LD_D
            {
                OpcodeNames.LD_D_B,LD_D_B
            },
            {
                OpcodeNames.LD_D_C,LD_D_C
            },
            {
                OpcodeNames.LD_D_D,LD_D_D
            },
            {
                OpcodeNames.LD_D_E,LD_D_E
            },
            {
                OpcodeNames.LD_D_H,LD_D_H
            },
            {
                OpcodeNames.LD_D_L,LD_D_L
            },
            {
                OpcodeNames.LD_D_HL,LD_D_HL
            },
            {
                OpcodeNames.LD_D_A,LD_D_A
            },
            #endregion
#region LD_E
            {
                OpcodeNames.LD_E_B,LD_E_B
            },
            {
                OpcodeNames.LD_E_C,LD_E_C
            },
            {
                OpcodeNames.LD_E_D,LD_E_D
            },
            {
                OpcodeNames.LD_E_E,LD_E_E
            },
            {
                OpcodeNames.LD_E_H,LD_E_H
            },
            {
                OpcodeNames.LD_E_L,LD_E_L
            },
            {
                OpcodeNames.LD_E_HL,LD_E_HL
            },
            {
                OpcodeNames.LD_E_A,LD_E_A
            },
            #endregion
            #region LD_H
            {
                OpcodeNames.LD_H_B,LD_H_B
            },
            {
                OpcodeNames.LD_H_C,LD_H_C
            },
            {
                OpcodeNames.LD_H_D,LD_H_D
            },
            {
                OpcodeNames.LD_H_E,LD_H_E
            },
            {
                OpcodeNames.LD_H_H,LD_H_H
            },
            {
                OpcodeNames.LD_H_L,LD_H_L
            },
            {
                OpcodeNames.LD_H_HL,LD_H_HL
            },
            {
                OpcodeNames.LD_H_A,LD_H_A
            },
            #endregion
            #region LD_L
            {
                OpcodeNames.LD_L_B,LD_L_B
            },
            {
                OpcodeNames.LD_L_C,LD_L_C
            },
            {
                OpcodeNames.LD_L_D,LD_L_D
            },
            {
                OpcodeNames.LD_L_E,LD_L_E
            },
            {
                OpcodeNames.LD_L_H,LD_L_H
            },
            {
                OpcodeNames.LD_L_L,LD_L_L
            },
            {
                OpcodeNames.LD_L_HL,LD_L_HL
            },
            {
                OpcodeNames.LD_L_A,LD_L_A
            },
            #endregion

            #region LD_L
            {
                OpcodeNames.LD_HL_B,LD_HL_B
            },
            {
                OpcodeNames.LD_HL_C,LD_HL_C
            },
            {
                OpcodeNames.LD_HL_D,LD_HL_D
            },
            {
                OpcodeNames.LD_HL_E,LD_HL_E
            },
            {
                OpcodeNames.LD_HL_H,LD_HL_H
            },
            {
                OpcodeNames.LD_HL_L,LD_HL_L
            },
            {
                OpcodeNames.LD_HL_A,LD_HL_A
            },
            #endregion
            
            #region ADD
            {
                OpcodeNames.ADD_A_B, ADD_A_B
            },
            {
                OpcodeNames.ADD_A_C, ADD_A_C
            },
            {
                OpcodeNames.ADD_A_D, ADD_A_D
            },
            {
                OpcodeNames.ADD_A_E, ADD_A_E
            },
            {
                OpcodeNames.ADD_A_H, ADD_A_H
            },
            #endregion
            
            #region JP
            {
                OpcodeNames.JP,JP
            },
            {
                OpcodeNames.JP_NZ,JP_NZ
            },
            {
                OpcodeNames.JP_NC,JP_NC
            },
            {
                OpcodeNames.JP_Z,JP_Z
            },
            {
                OpcodeNames.JP_C,JP_C
            },
            #endregion
        };
        #endregion

    }

}