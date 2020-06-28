namespace CoreBoy.Emulator
{
    public static class OpcodeNames
    {

        #region INC
        #region INC_R16
        public const string INC_BC = "INC_BC";
        public const string INC_DE = "INC_DE";
        public const string INC_HL = "INC_HL";
        public const string INC_SP = "INC_SP";
        #endregion

        #region INC_R8
        public const string INC_A = "INC_A";
        public const string INC_B = "INC_B";
        public const string INC_C = "INC_C";
        public const string INC_D = "INC_D";
        public const string INC_E = "INC_E";
        public const string INC_H = "INC_H";
        public const string INC_L = "INC_L";
        #endregion
        #endregion

        #region DEC
        #region DEC_R16
        public const string DEC_BC = "DEC_BC";
        public const string DEC_DE = "DEC_DE";
        public const string DEC_HL = "DEC_HL";
        public const string DEC_SP = "DEC_SP";
        #endregion

        #region DEC_R8
        public const string DEC_A = "DEC_A";
        public const string DEC_B = "DEC_B";
        public const string DEC_C = "DEC_C";
        public const string DEC_D = "DEC_D";
        public const string DEC_E = "DEC_E";
        public const string DEC_H = "DEC_H";
        public const string DEC_L = "DEC_L";
        #endregion
        #endregion

        #region ADD
        public const string ADD_A_B = "ADD_A_B";
        public const string ADD_A_C = "ADD_A_C";
        public const string ADD_A_D = "ADD_A_D";
        public const string ADD_A_E = "ADD_A_E";
        public const string ADD_A_H = "ADD_A_H";
        #endregion

        #region CP
        public const string CP_D8 = "CP_D8";
        public const string CP_A = "CP_A";
        public const string CP_B = "CP_B";
        public const string CP_C = "CP_C";
        public const string CP_D = "CP_D";
        public const string CP_E = "CP_E";
        public const string CP_H = "CP_H";
        public const string CP_L = "CP_L";
        public const string CP_HL = "CP_HL";
        #endregion

        #region SUB
        public const string SUB_D8 = "SUB_D8";
        public const string SUB_A = "SUB_A";
        public const string SUB_B = "SUB_B";
        public const string SUB_C = "SUB_C";
        public const string SUB_D = "SUB_D";
        public const string SUB_E = "SUB_E";
        public const string SUB_H = "SUB_H";
        public const string SUB_L = "SUB_L";
        public const string SUB_HL = "SUB_HL";
        #endregion

        #region JP
        public const string JP = "JP";
        public const string JP_NZ = "JP_NZ";
        public const string JP_Z = "JP_Z";
        public const string JP_NC = "JP_NC";
        public const string JP_C = "JP_C";
        #endregion

        #region JR
        public const string JR = "JR";
        public const string JR_NZ = "JR_NZ";
        public const string JR_Z = "JR_Z";
        public const string JR_NC = "JR_NC";
        public const string JR_C = "JR_C";
        #endregion

        #region LD
        #region LD_A
        public const string LD_A_A = "LD_A_A";
        public const string LD_A_B = "LD_A_B";
        public const string LD_A_C = "LD_A_C";
        public const string LD_A_D = "LD_A_D";
        public const string LD_A_E = "LD_A_E";
        public const string LD_A_H = "LD_A_H";
        public const string LD_A_L = "LD_A_L";
        public const string LD_A_HL = "LD_A_HL";
        public const string LD_A_D8 = "LD_A_D8";
        #endregion
        #region LD_B
        public const string LD_B_A = "LD_B_A";
        public const string LD_B_B = "LD_B_B";
        public const string LD_B_C = "LD_B_C";
        public const string LD_B_D = "LD_B_D";
        public const string LD_B_E = "LD_B_E";
        public const string LD_B_H = "LD_B_H";
        public const string LD_B_L = "LD_B_L";
        public const string LD_B_HL = "LD_B_HL";
        public const string LD_B_D8 = "LD_B_D8";
        #endregion
        #region LD_C
        public const string LD_C_A = "LD_C_A";
        public const string LD_C_B = "LD_C_B";
        public const string LD_C_C = "LD_C_C";
        public const string LD_C_D = "LD_C_D";
        public const string LD_C_E = "LD_C_E";
        public const string LD_C_H = "LD_C_H";
        public const string LD_C_L = "LD_C_L";
        public const string LD_C_HL = "LD_C_HL";
        public const string LD_C_D8 = "LD_C_D8";
        #endregion
        #region LD_D
        public const string LD_D_A = "LD_D_A";
        public const string LD_D_B = "LD_D_B";
        public const string LD_D_C = "LD_D_C";
        public const string LD_D_D = "LD_D_D";
        public const string LD_D_E = "LD_D_E";
        public const string LD_D_H = "LD_D_H";
        public const string LD_D_L = "LD_D_L";
        public const string LD_D_HL = "LD_D_HL";
        public const string LD_D_D8 = "LD_D_D8";
        #endregion
        #region LD_E
        public const string LD_E_A = "LD_E_A";
        public const string LD_E_B = "LD_E_B";
        public const string LD_E_C = "LD_E_C";
        public const string LD_E_D = "LD_E_D";
        public const string LD_E_E = "LD_E_E";
        public const string LD_E_H = "LD_E_H";
        public const string LD_E_L = "LD_E_L";
        public const string LD_E_HL = "LD_E_HL";
        public const string LD_E_D8 = "LD_E_D8";
        #endregion
        #region LD_H
        public const string LD_H_A = "LD_H_A";
        public const string LD_H_B = "LD_H_B";
        public const string LD_H_C = "LD_H_C";
        public const string LD_H_D = "LD_H_D";
        public const string LD_H_E = "LD_H_E";
        public const string LD_H_H = "LD_H_H";
        public const string LD_H_L = "LD_H_L";
        public const string LD_H_HL = "LD_H_HL";
        public const string LD_H_D8 = "LD_H_D8";
        #endregion
        #region LD_L
        public const string LD_L_A = "LD_L_A";
        public const string LD_L_B = "LD_L_B";
        public const string LD_L_C = "LD_L_C";
        public const string LD_L_D = "LD_L_D";
        public const string LD_L_E = "LD_L_E";
        public const string LD_L_H = "LD_L_H";
        public const string LD_L_L = "LD_L_L";
        public const string LD_L_HL = "LD_L_HL";
        public const string LD_L_D8 = "LD_L_D8";
        #endregion
        #region LD_HL
        public const string LD_HL_B = "LD_HL_B";
        public const string LD_HL_C = "LD_HL_C";
        public const string LD_HL_D = "LD_HL_D";
        public const string LD_HL_E = "LD_HL_E";
        public const string LD_HL_H = "LD_HL_H";
        public const string LD_HL_L = "LD_HL_L";
        public const string LD_HL_A = "LD_HL_A";
        public const string LD_HL_D8 = "LD_HL_D8";
        #endregion

        #region LD_R16_D16
        public const string LD_BC_D16 = "LD_BC_D16";
        public const string LD_DE_D16 = "LD_DE_D16";
        public const string LD_HL_D16 = "LD_HL_D16";
        public const string LD_SP_D16 = "LD_SP_D16";
        #endregion

        #region LD_(R16)_A
        public const string LD_BC_A = "LD_BC_A";
        public const string LD_DE_A = "LD_DE_A";

        #endregion

        #region LDH
        public const string LDH_A_A8 = "LDH_A_A8";
        public const string LDH_A8_A = "LDH_A8_A";
        #endregion
        #endregion

        #region PUSH
        public const string PUSH_AF = "PUSH_AF";
        public const string PUSH_BC = "PUSH_BC";
        public const string PUSH_DE = "PUSH_DE";
        public const string PUSH_HL = "PUSH_HL";
        #endregion

        #region POP
        public const string POP_AF = "POP_AF";
        public const string POP_BC = "POP_BC";
        public const string POP_DE = "POP_DE";
        public const string POP_HL = "POP_HL";
        #endregion

        #region CALL
        public const string CALL = "CALL";
        public const string CALL_Z = "CALL_Z";
        public const string CALL_NZ = "CALL_NZ";
        public const string CALL_C = "CALL_C";
        public const string CALL_NC = "CALL_NC";
        #endregion

        #region RET
        public const string RET = "RET";
        public const string RET_Z = "RET_Z";
        public const string RET_NZ = "RET_NZ";
        public const string RET_C = "RET_C";
        public const string RET_NC = "RET_NC";
        #endregion

        #region RST
        public const string RST_00 = "RST_00";
        public const string RST_08 = "RST_08";
        public const string RST_10 = "RST_10";
        public const string RST_18 = "RST_18";
        public const string RST_20 = "RST_20";
        public const string RST_28 = "RST_28";
        public const string RST_30 = "RST_30";
        public const string RST_38 = "RST_38";

        #endregion

        #region AND
        public const string AND_D8 = "AND_D8";
        public const string AND_B = "AND_B";
        public const string AND_C = "AND_C";
        public const string AND_D = "AND_D";
        public const string AND_E = "AND_E";
        public const string AND_H = "AND_H";
        public const string AND_L = "AND_L";

        public const string AND_HL = "AND_HL";
        public const string AND_A = "AND_A";
        #endregion

        #region OR
        public const string OR_D8 = "OR_D8";
        public const string OR_B = "OR_B";
        public const string OR_C = "OR_C";
        public const string OR_D = "OR_D";
        public const string OR_E = "OR_E";
        public const string OR_H = "OR_H";
        public const string OR_L = "OR_L";

        public const string OR_HL = "OR_HL";
        public const string OR_A = "OR_A";
        #endregion

        #region XOR
        public const string XOR_D8 = "XOR_D8";
        public const string XOR_B = "XOR_B";
        public const string XOR_C = "XOR_C";
        public const string XOR_D = "XOR_D";
        public const string XOR_E = "XOR_E";
        public const string XOR_H = "XOR_H";
        public const string XOR_L = "XOR_L";

        public const string XOR_HL = "XOR_HL";
        public const string XOR_A = "XOR_A";
        #endregion


        #region Bitwise Logic


        #region Bit
        #region Bit 0
        public const string BIT_0_A = "BIT_0_A";
        public const string BIT_0_B = "BIT_0_B";
        public const string BIT_0_C = "BIT_0_C";
        public const string BIT_0_D = "BIT_0_D";
        public const string BIT_0_E = "BIT_0_E";
        public const string BIT_0_H = "BIT_0_H";
        public const string BIT_0_L = "BIT_0_L";
        public const string BIT_0_HL = "BIT_0_HL";

        #endregion

        #region Bit 1
        public const string BIT_1_A = "BIT_1_A";
        public const string BIT_1_B = "BIT_1_B";
        public const string BIT_1_C = "BIT_1_C";
        public const string BIT_1_D = "BIT_1_D";
        public const string BIT_1_E = "BIT_1_E";
        public const string BIT_1_H = "BIT_1_H";
        public const string BIT_1_L = "BIT_1_L";
        public const string BIT_1_HL = "BIT_1_HL";

        #endregion

        #region Bit 2
        public const string BIT_2_A = "BIT_2_A";
        public const string BIT_2_B = "BIT_2_B";
        public const string BIT_2_C = "BIT_2_C";
        public const string BIT_2_D = "BIT_2_D";
        public const string BIT_2_E = "BIT_2_E";
        public const string BIT_2_H = "BIT_2_H";
        public const string BIT_2_L = "BIT_2_L";
        public const string BIT_2_HL = "BIT_2_HL";

        #endregion

        #region Bit 3
        public const string BIT_3_A = "BIT_3_A";
        public const string BIT_3_B = "BIT_3_B";
        public const string BIT_3_C = "BIT_3_C";
        public const string BIT_3_D = "BIT_3_D";
        public const string BIT_3_E = "BIT_3_E";
        public const string BIT_3_H = "BIT_3_H";
        public const string BIT_3_L = "BIT_3_L";
        public const string BIT_3_HL = "BIT_3_HL";

        #endregion

        #region Bit 4
        public const string BIT_4_A = "BIT_4_A";
        public const string BIT_4_B = "BIT_4_B";
        public const string BIT_4_C = "BIT_4_C";
        public const string BIT_4_D = "BIT_4_D";
        public const string BIT_4_E = "BIT_4_E";
        public const string BIT_4_H = "BIT_4_H";
        public const string BIT_4_L = "BIT_4_L";
        public const string BIT_4_HL = "BIT_4_HL";

        #endregion

        #region Bit 5
        public const string BIT_5_A = "BIT_5_A";
        public const string BIT_5_B = "BIT_5_B";
        public const string BIT_5_C = "BIT_5_C";
        public const string BIT_5_D = "BIT_5_D";
        public const string BIT_5_E = "BIT_5_E";
        public const string BIT_5_H = "BIT_5_H";
        public const string BIT_5_L = "BIT_5_L";
        public const string BIT_5_HL = "BIT_5_HL";

        #endregion

        #region Bit 6
        public const string BIT_6_A = "BIT_6_A";
        public const string BIT_6_B = "BIT_6_B";
        public const string BIT_6_C = "BIT_6_C";
        public const string BIT_6_D = "BIT_6_D";
        public const string BIT_6_E = "BIT_6_E";
        public const string BIT_6_H = "BIT_6_H";
        public const string BIT_6_L = "BIT_6_L";
        public const string BIT_6_HL = "BIT_6_HL";

        #endregion

        #region Bit 7
        public const string BIT_7_A = "BIT_7_A";
        public const string BIT_7_B = "BIT_7_B";
        public const string BIT_7_C = "BIT_7_C";
        public const string BIT_7_D = "BIT_7_D";
        public const string BIT_7_E = "BIT_7_E";
        public const string BIT_7_H = "BIT_7_H";
        public const string BIT_7_L = "BIT_7_L";
        public const string BIT_7_HL = "BIT_7_HL";

        #endregion
        #endregion

        public const string RRCA = "RRCA";
        #endregion

        public const string NOP = "NOP";
        public const string STOP = "STOP";
        public const string HALT = "HALT";
        public const string DI = "DI";
        public const string CCF = "CCF";
    }
}