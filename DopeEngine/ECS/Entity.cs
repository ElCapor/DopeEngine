using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DopeEngine.ECS
{
    public class Entity
    {
        internal Entity(int id)
        {
            this.ID = id;
        }

        public int ID { get; }
        public List<Entity> children = new List<Entity>();
        public Entity? parent = null;
    }

    public class EntityManager
    {
        public EntityManager() { }
        public int _next = -1;
        private static readonly EntityManager _singleton = new();
        public HashSet<Entity> _entities = new HashSet<Entity>();
        private Dictionary<Entity, List<Component>> componentsTable;

        public static EntityManager GetSingleton()
        {
            return _singleton;
        }

        public Entity NewEntity()
        {
            _next++;
            _entities.Add(new Entity(_next));
            return _entities.ElementAt(_next);
        }

        private Entity GetEntityById(int id)
        {
            return _entities.ElementAt(id);
        }

        public void SetParent(Entity parent, Entity _entity)
        {
            if (_entity.parent == null && !parent.children.Contains(entity => entity.ID == _entity.ID))
            {
                _entity.parent = parent;
                parent.children.Add(_entity);
            } 
            else
            {
                Console.WriteLine("Parent already exists");
            }
        }

        public void AddChild(Entity _child, Entity entity)
        {

        }
    }
}
