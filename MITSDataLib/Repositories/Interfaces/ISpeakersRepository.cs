﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MITSDataLib.Models;

namespace MITSDataLib.Repositories.Interfaces
{
    public interface ISpeakersRepository
    {
        Task<List<Speaker>> GetSpeakersAsync();
        Task<List<Speaker>> GetSpeakersBySectionIdAsync(int id);
        Task<Speaker> GetSpeakerByIdAsync(int speakerId);
        Task<Speaker> CreateSpeakerAsync(Speaker newSpeaker);
        Task<Speaker> UpdateSpeakerAsync(Speaker newSpeakerValues);
        Task<int> DeleteSpeakerAsync(int speakerId);
    }
}
