﻿namespace MYPOP
{
    public interface IBotHost
    {
        Task StartAsync();

        Task StopAsync();
    }
}