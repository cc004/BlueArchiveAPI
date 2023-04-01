﻿using Newtonsoft.Json.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace BlueArchiveAPI.NetworkModels
{
    public abstract class Packet
    {
        public abstract Protocol Protocol { get; } 
    }
    
    public abstract class Request<T> : Packet where T : Packet
    {

    }
    
    public abstract class Response<T> : Packet where T : Packet
    {

    }
    
    public class TypedJsonWrapper<T> where T : class
    {
        public T Instance;

        public static implicit operator TypedJsonWrapper<T>(T obj)
        {
            return new TypedJsonWrapper<T>(obj);
        }

        public TypedJsonWrapper(T obj)
        {
            Instance = obj;
        }
    }

    public struct Vector3
    {
        public float x, y, z;
    }
}
