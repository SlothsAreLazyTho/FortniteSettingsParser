﻿namespace FortniteSettingsParser.Property
{
    public class FQuat : UStruct
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        public float Z { get; private set; }
        public float W { get; private set; }

        protected internal override void DeserializeProperty(UnrealBinaryReader reader)
        {
            X = reader.ReadSingle();
            Y = reader.ReadSingle();
            Z = reader.ReadSingle();
            W = reader.ReadSingle();

            Value = $"X: {X}, Y: {Y}, Z: {Z}, W: {W}";
        }
    }
}
