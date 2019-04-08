﻿[System.Serializable]
public class DeviceModel
{
    public int Id { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public string State { get; set; }
    public string Localization { get; set; }
    public bool Disabled { get; set; }
}