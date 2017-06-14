using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvShowsLibraryData.Models;

namespace TvShowsLibraryData.Data
{
    public class TvShowsRepository : ITvShowsRepository
    {
        private TvShowsDbContext _ctx;

        public TvShowsRepository(TvShowsDbContext ctx)
        {
            _ctx = ctx;
        }

        public bool AddEpisode(Episode ep)
        {
            try
            {
                _ctx.Episodes.Add(ep);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AddSeasonToTvShow(Season s)
        {
            try
            {
                _ctx.Seasons.Add(s);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AddTvShow(TvShow ts)
        {
            try
            {
                _ctx.TvShows.Add(ts);
                _ctx.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<TvShow> GetAllTvShows()
        {
            return _ctx.TvShows.ToList();
        }

        public IEnumerable<Episode> GetEpisodesBySeason(int seasonId)
        {
            return _ctx.Episodes.Where(ep => ep.SeasonId == seasonId).ToList();
        }

        public IEnumerable<Season> GetSeasonsByShowId(int tvShowId)
        {
            return _ctx.Seasons.Where(ss => ss.TvShowId == tvShowId).ToList();
        }

        public TvShow GetTvShowById(int tvShowId)
        {
            return _ctx.TvShows.Where(tvs => tvs.Id == tvShowId).FirstOrDefault();
        }

        public bool RemoveEpisode(Episode ep)
        {
            throw new NotImplementedException();
        }

        public bool RemoveSeason(Season s)
        {
            throw new NotImplementedException();
        }

        public bool RemoveTvShow(TvShow ts)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEpisode(Episode ep)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSeason(Season s)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTvShow(TvShow ts)
        {
            throw new NotImplementedException();
        }
    }
}
