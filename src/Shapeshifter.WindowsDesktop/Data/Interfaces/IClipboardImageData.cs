﻿namespace Shapeshifter.WindowsDesktop.Data.Interfaces
{
    public interface IClipboardImageData: IClipboardData
    {
        byte[] Image { get; }
    }
}