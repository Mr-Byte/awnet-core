using System;
using System.Runtime.InteropServices;
using System.Text;

namespace AW
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [Serializable]
    public sealed class ParticleFlags
    {
        private ushort flags;
        private static readonly ushort[] flagValues = { 0x0001, 0x0002, 0x0004, 0x0008, 0x0010, 0x0020, 0x0040 };
        /**
         *  AW_PARTICLE_FLAG_INTERPOLATE    = 0x01, 0
         *  AW_PARTICLE_FLAG_GRAVITY        = 0x02, 1
         *  AW_PARTICLE_FLAG_COLLIDE_ZONES  = 0x04, 2
         *  AW_PARTICLE_FLAG_ZONE_EXCLUSIVE = 0x08, 3
         *  AW_PARTICLE_FLAG_CAMERA_EMIT    = 0x10, 4
         *  AW_PARTICLE_FLAG_MOVER_LINK     = 0x20, 5
         *  AW_PARTICLE_DRAW_IN_FRONT       = 0x40, 6
         */

        public bool Interpolate
        {
            get
            {
                return (flags & flagValues[0]) == flagValues[0];
            }

            set
            {
                flags = (ushort)(value ? (flags | flagValues[0]) : (flags & ~flagValues[0]));
            }
        }

        public bool Gravity
        {
            get
            {
                return (flags & flagValues[1]) == flagValues[1];
            }

            set
            {
                flags = (ushort)(value ? (flags | flagValues[1]) : (flags & ~flagValues[1]));
            }
        }

        public bool ZoneCollision
        {
            get
            {
                return (flags & flagValues[2]) == flagValues[2];
            }

            set
            {
                flags = (ushort)(value ? (flags | flagValues[2]) : (flags & ~flagValues[2]));
            }
        }

        public bool ZoneExclusive
        {
            get
            {
                return (flags & flagValues[3]) == flagValues[3];
            }

            set
            {
                flags = (ushort)(value ? (flags | flagValues[3]) : (flags & ~flagValues[3]));
            }
        }

        public bool CameraEmit
        {
            get
            {
                return (flags & flagValues[4]) == flagValues[4];
            }

            set
            {
                flags = (ushort)(value ? (flags | flagValues[4]) : (flags & ~flagValues[4]));
            }
        }

        public bool LinkToMover
        {
            get
            {
                return (flags & flagValues[5]) == flagValues[5];
            }

            set
            {
                flags = (ushort)(value ? (flags | flagValues[5]) : (flags & ~flagValues[5]));
            }
        }

        public bool DrawInFront
        {
            get
            {
                return (flags & flagValues[6]) == flagValues[6];
            }

            set
            {
                flags = (ushort)(value ? (flags | flagValues[6]) : (flags & ~flagValues[6]));
            }
        }
    }

    public sealed class Particle : V4Object
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private class ParticleData
        {
            public VectorRange volume = new VectorRange();
            public byte version = 1;
            public VectorRange speed = new VectorRange();
            public VectorRange accel = new VectorRange();
            public VectorRange angle = new VectorRange();
            public VectorRange spin = new VectorRange();
            public VectorRange size = new VectorRange();
            public int release_min;
            public int release_max;
            public short release_size;
            public int lifespan;
            public int emitter_lifespan;
            public int fade_in;
            public int fade_out;
            public uint color_start = 0xFFFFFFFF;
            public uint color_end = 0xFFFFFFFF;
            public float opacity = 1.0f;
            public byte render_style;
            public ParticleFlags flags = new ParticleFlags();
            public byte style;
            public short asset_list_len;
            public byte name_len;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] reserved;
        }

        private ParticleData _particleData = new ParticleData();
        private byte[] _remainder;

        private string _assetList = string.Empty;
        private string _name = string.Empty;

        public ParticleFlags Flags
        {
            get { return _particleData.flags; }
            set { _particleData.flags = value; }
        }

        public VectorRange Volume
        {
            get { return _particleData.volume; }
            set { _particleData.volume = value; }
        }

        public VectorRange Speed
        {
            get { return _particleData.speed; }
            set { _particleData.speed = value; }
        }

        public VectorRange Acceleration
        {
            get { return _particleData.accel; }
            set { _particleData.accel = value; }
        }

        public VectorRange Angle
        {
            get { return _particleData.angle; }
            set { _particleData.angle = value; }
        }

        public VectorRange Spin
        {
            get { return _particleData.spin; }
            set { _particleData.spin = value; }
        }

        public VectorRange Size
        {
            get { return _particleData.size; }
            set { _particleData.size = value; }
        }

        public int ReleaseMinimum
        {
            get { return _particleData.release_min; }
            set { _particleData.release_min = value; }
        }

        public int ReleaseMaximum
        {
            get { return _particleData.release_max; }
            set { _particleData.release_max = value; }
        }

        public short ReleaseSize
        {
            get { return _particleData.release_size; }
            set { _particleData.release_size = value; }
        }

        public int Lifespan
        {
            get { return _particleData.lifespan; }
            set { _particleData.lifespan = value; }
        }

        public int EmitterLifespan
        {
            get { return _particleData.emitter_lifespan; }
            set { _particleData.emitter_lifespan = value; }
        }

        public int FadeIn
        {
            get { return _particleData.fade_in; }
            set { _particleData.fade_in = value; }
        }

        public int FadeOut
        {
            get { return _particleData.fade_out; }
            set { _particleData.fade_out = value; }
        }

        public Color ColorStart
        {
            get
            {
                return (int)_particleData.color_start;
            }

            set
            {
                _particleData.color_start = (uint)(int)value;
            }
        }

        public Color ColorEnd
        {
            get
            {
                return (int)_particleData.color_end;
            }

            set
            {
                _particleData.color_end = (uint)(int)value;
            }
        }

        public float Opacity
        {
            get { return _particleData.opacity; }
            set { _particleData.opacity = value; }
        }

        public ParticleDrawStyle RenderStyle
        {
            get { return (ParticleDrawStyle)_particleData.render_style; }
            set { _particleData.render_style = (byte)value; }
        }

        public ParticleType Style
        {
            get { return (ParticleType)_particleData.style; }
            set { _particleData.style = (byte)value; }
        }

        public string AssetList
        {
            get { return _assetList; }
            set { _assetList = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        internal override byte[] GetData()
        {
            _particleData.asset_list_len = (short)Encoding.UTF8.GetByteCount(_assetList);
            _particleData.name_len = (byte)Encoding.UTF8.GetByteCount(_name);

            return Utilities.Miscellaneous.ConcatArrays(Utilities.Miscellaneous.StructToBytes(_particleData),
                                             Encoding.UTF8.GetBytes(_assetList),
                                             Encoding.UTF8.GetBytes(_name),
                                             new byte[] { 0 }
                                            );

        }

        internal override void SetData(byte[] data)
        {
            _particleData = Utilities.Miscellaneous.BytesToStruct<ParticleData>(data, 0);
            int size = data.Length - Marshal.SizeOf(typeof(ParticleData));
            _remainder = new byte[size];
            Array.ConstrainedCopy(data, data.Length - size, _remainder, 0, size);

            _assetList = Encoding.UTF8.GetString(_remainder, 0, _particleData.asset_list_len);
            _name = Encoding.UTF8.GetString(_remainder, _particleData.asset_list_len, _particleData.name_len);
        }
    }
}