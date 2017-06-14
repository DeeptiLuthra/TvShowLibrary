using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvShowsLibraryData.Models;

namespace TvShowsLibraryData.Data
{
    public interface ITvShowsRepository
    {
        bool AddTvShow(TvShow ts);
        bool UpdateTvShow(TvShow ts);
        bool RemoveTvShow(TvShow ts);
        bool AddSeasonToTvShow(Season s);
        bool UpdateSeason(Season s);
        bool RemoveSeason(Season s);
        bool AddEpisode(Episode ep);
        bool UpdateEpisode(Episode ep);
        bool RemoveEpisode(Episode ep);
        IEnumerable<TvShow> GetAllTvShows();
        TvShow GetTvShowById(int tvShowId);
        IEnumerable<Season> GetSeasonsByShowId(int tvShowId);
        IEnumerable<Episode> GetEpisodesBySeason(int seasonId);


    }
}
