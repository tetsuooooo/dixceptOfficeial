using DixseptData.Entity;
using DixseptData.Entity.Table;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace DixseptData
{
    public interface IUnitOfWork : IDisposable 
    {
        DixseptContext Context { get; }

        IRepository<M_PLAYER> M_PLAYER { get; }
        IRepository<M_POSITION> M_POSITION { get; }
        IRepository<M_TEAM> M_TEAM { get; }
        IRepository<M_TOURNAMENT> M_TOURNAMENT { get; }
        IRepository<T_NEWS> T_NEWS { get; }
        IRepository<T_OFFICIAL_RESULT> T_OFFICIAL_RESULT { get; }
        IRepository<T_OFFICIAL_POINT> T_OFFICIAL_POINT { get; }
        IRepository<T_PRACTICEGAME_SCHEDULE> T_PRACTICEGAME_SCHEDULE { get; }
        IRepository<T_PRACTICEGAME_DETAIL> T_PRACTICEGAME_DETAIL { get; }

        IRepository<T_PRACTICEGAME_POINT> T_PRACTICEGAME_POINT { get; }
        IRepository<T_PRACTICE_SCHEDULE> T_PRACTICE_SCHEDULE { get; }

        #region Method
        IDbContextTransaction BeginTran();

        int SaveChanges();

        void DetachAllEntities();

        #endregion


    }

    public class UnitOfWork<T> : IUnitOfWork where T : DixseptContext
    {
        public DixseptContext Context { get; }
        private bool _disposed = false;

        public UnitOfWork(T context) 
        {
            Context = context;
        }

        private IRepository<M_PLAYER> _player;
        public IRepository<M_PLAYER> M_PLAYER => _player ?? (_player = new Repository<M_PLAYER>(Context));

        /// <summary>
        /// 上のgetterと同じ意味
        /// </summary>
        //public IRepository<M_PLAYER> M_PLAYER() 
        //{
        //    if (_player == null) 
        //    {
        //        return new Repository<M_PLAYER>(Context);
        //    }

        //    return _player;
        //}

        private IRepository<M_POSITION> _position;
        public IRepository<M_POSITION> M_POSITION => _position ?? (_position = new Repository<M_POSITION>(Context));

        private IRepository<M_TEAM> _team;
        public IRepository<M_TEAM> M_TEAM => _team ?? (_team = new Repository<M_TEAM>(Context));

        private IRepository<T_NEWS> _news;
        public IRepository<T_NEWS> T_NEWS => _news ?? (_news = new Repository<T_NEWS>(Context));

        private IRepository<M_TOURNAMENT> _tournament;
        public IRepository<M_TOURNAMENT> M_TOURNAMENT => _tournament ?? (_tournament = new Repository<M_TOURNAMENT>(Context));

        private IRepository<T_OFFICIAL_SCHEDULE> _officialSchedule;
        public IRepository<T_OFFICIAL_SCHEDULE> T_OFFICIAL_SCHEDULE => _officialSchedule ?? (_officialSchedule = new Repository<T_OFFICIAL_SCHEDULE>(Context));

        private IRepository<T_OFFICIAL_POINT> _offiialPoint;
        public IRepository<T_OFFICIAL_POINT> T_OFFICIAL_POINT => _offiialPoint ?? (_offiialPoint = new Repository<T_OFFICIAL_POINT>(Context));

        private IRepository<T_OFFICIAL_RESULT> _officialResult;
        public IRepository<T_OFFICIAL_RESULT> T_OFFICIAL_RESULT => _officialResult ?? (_officialResult = new Repository<T_OFFICIAL_RESULT>(Context));

        private IRepository<T_PRACTICEGAME_POINT> _practicePoint;
        public IRepository<T_PRACTICEGAME_POINT> T_PRACTICEGAME_POINT => _practicePoint ?? (_practicePoint = new Repository<T_PRACTICEGAME_POINT>(Context));

        private IRepository<T_PRACTICEGAME_SCHEDULE> _practiceGameSchedule;
        public IRepository<T_PRACTICEGAME_SCHEDULE> T_PRACTICEGAME_SCHEDULE => _practiceGameSchedule ?? (_practiceGameSchedule = new Repository<T_PRACTICEGAME_SCHEDULE>(Context));

        private IRepository<T_PRACTICEGAME_DETAIL> _practiceGameDetail;
        public IRepository<T_PRACTICEGAME_DETAIL> T_PRACTICEGAME_DETAIL => _practiceGameDetail ?? (_practiceGameDetail = new Repository<T_PRACTICEGAME_DETAIL>(Context));

        private IRepository<T_PRACTICE_SCHEDULE> _practiceSchedule;
        public IRepository<T_PRACTICE_SCHEDULE> T_PRACTICE_SCHEDULE => _practiceSchedule ?? (_practiceSchedule = new Repository<T_PRACTICE_SCHEDULE>(Context));
        public IDbContextTransaction BeginTran() => Context.Database.BeginTransaction();

        public int SaveChanges() => Context.SaveChanges();

        public void DetachAllEntities() => Context.DetachAllEntities();

        public void Dispose() 
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing) 
        {
            if (_disposed) return;

            if (disposing) 
            {
                Context.Dispose();
            }

            _disposed = true;
        }
        
    }
}
