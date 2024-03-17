using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_star_8tasbulmacasi
{

    public class PuzzleSolver
    {
        public List<PuzzleState> SolvePuzzleWithSteps(PuzzleState initialState)
        {
            var openSet = new MinHeap<PuzzleState>();
            var closedSet = new HashSet<PuzzleState>();
            openSet.Insert(initialState);

            while (openSet.Count > 0)
            {
                var current = openSet.RemoveMin();

                if (current.IsGoal())
                {
                    return ReconstructPath(current);
                }

                closedSet.Add(current);

                foreach (var neighbor in current.GetNeighbors())
                {
                    if (closedSet.Contains(neighbor))
                        continue;

                    int tentativeGScore = current.GScore + 1;

                    if (!openSet.Contains(neighbor) || tentativeGScore < neighbor.GScore)
                    {
                        neighbor.CameFrom = current;
                        neighbor.GScore = tentativeGScore;
                        neighbor.FScore = neighbor.GScore + neighbor.HScore;

                        if (!openSet.Contains(neighbor))
                        {
                            openSet.Insert(neighbor);
                        }
                    }
                }
            }

            return null; // Çözüm bulunamadı
        }

        private List<PuzzleState> ReconstructPath(PuzzleState state)
        {
            List<PuzzleState> path = new List<PuzzleState>();
            PuzzleState current = state;

            while (current != null)
            {
                path.Insert(0, current);
                current = current.CameFrom;
            }

            return path;
        }

    }
}
