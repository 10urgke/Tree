class Tree
{

// Ağacın düğümünü temsil eder.
    public class Node
    {
        public int key;
        public List<Node >child = new List<Node>();
    };

// Yeni bir ağaç düğüümü oluşturmak için yardımcı.
    static Node newNode(int key)
    {
        Node temp = new Node();
        temp.key = key;
        return temp;
    }

// Ağacı yazdırır.
    static void LevelOrderTraversal(Node root)
    {
        if (root == null)
            return;

        // Queue kullanarak seviye geçişi
        Queue<Node> q = new Queue<Node>(); // Queue oluşturma.
        q.Enqueue(root); // rootu queueya eklemek
        while (q.Count != 0)
        {
            int n = q.Count;

            // bu düğümün çocukları varsa
            while (n > 0)
            {
                // bir öğeyi kuyruktan çıkart ve yazdır
                Node p = q.Peek();
                q.Dequeue();
                Console.Write(p.key + " ");

                // Kuyruğa alınan öğrenin tüm çocuklarını kuyruğa al.
                for (int i = 0; i < p.child.Count; i++)
                    q.Enqueue(p.child[i]);
                n--;
            }
		
            // 2 seviye arasında yeni bir satır yazdır.
            Console.WriteLine();
        }
    }
    
    public static void Main(String[] args)
    {

        /*  Tree Yapısı
      *             10
      *          / / \ \
      *         2 34 56 100
      *        / \   | / | \
      *       77 88  1 7 8 9
      */
        
        Node root = newNode(10);
        (root.child).Add(newNode(2));
        (root.child).Add(newNode(34));
        (root.child).Add(newNode(56));
        (root.child).Add(newNode(100));
        (root.child[0].child).Add(newNode(77));
        (root.child[0].child).Add(newNode(88));
        (root.child[2].child).Add(newNode(1));
        (root.child[3].child).Add(newNode(7));
        (root.child[3].child).Add(newNode(8));
        (root.child[3].child).Add(newNode(9));

        Console.WriteLine("Tree Yapısı ");
        LevelOrderTraversal(root);
    }
}



