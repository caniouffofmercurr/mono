// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
/*============================================================
**
** Class:  SymAddressKind
**
**
** Represents address Kinds used with local variables, parameters, and
** fields.
**
** 
===========================================================*/
namespace System.Diagnostics.SymbolStore {
    // Only statics, does not need to be marked with the serializable attribute    
    using System;

    [Serializable]
[System.Runtime.InteropServices.ComVisible(true)]
    public enum SymAddressKind
    {
        // ILOffset: addr1 = IL local var or param index.
        ILOffset = 1,
    
        // NativeRVA: addr1 = RVA into module.
        NativeRVA = 2,
    
        // NativeRegister: addr1 = register the var is stored in.
        NativeRegister = 3,
    
        // NativeRegisterRelative: addr1 = register, addr2 = offset.
        NativeRegisterRelative = 4,
    
        // NativeOffset: addr1 = offset from start of parent.
        NativeOffset = 5,
    
        // NativeRegisterRegister: addr1 = reg low, addr2 = reg high.
        NativeRegisterRegister = 6,
    
        // NativeRegisterStack: addr1 = reg low, addr2 = reg stk, addr3 = offset.
        NativeRegisterStack = 7,
    
        // NativeStackRegister: addr1 = reg stk, addr2 = offset, addr3 = reg high.
        NativeStackRegister = 8,
    
        // BitField: addr1 = field start, addr = field length.
        BitField = 9,

        // NativeSectionOffset: addr1 = section, addr = offset
        NativeSectionOffset = 10,
    }
}
