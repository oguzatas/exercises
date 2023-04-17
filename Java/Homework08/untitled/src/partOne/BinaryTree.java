package partOne;

import java.util.LinkedList;
import java.util.Queue;

import java.util.LinkedList;
import java.util.Queue;

public class BinaryTree {
    private Node root;

    private class Node {
        int data;
        Node left;
        Node right;

        Node(int data) {
            this.data = data;
        }
    }

    public void insert(int data) {
        root = insert(root, data);
    }

    private Node insert(Node node, int data) {
        if (node == null) {
            node = new Node(data);
        } else {
            if (data <= node.data) {
                node.left = insert(node.left, data);
            } else {
                node.right = insert(node.right, data);
            }
        }
        return node;
    }

    public void delete(int data) {
        root = delete(root, data);
    }

    private Node delete(Node node, int data) {
        if (node == null) {
            return node;
        }
        if (data < node.data) {
            node.left = delete(node.left, data);
        } else if (data > node.data) {
            node.right = delete(node.right, data);
        } else {
            if (node.left == null) {
                return node.right;
            } else if (node.right == null) {
                return node.left;
            }
            node.data = minValue(node.right);
            node.right = delete(node.right, node.data);
        }
        return node;
    }

    private int minValue(Node node) {
        int minv = node.data;
        while (node.left != null) {
            minv = node.left.data;
            node = node.left;
        }
        return minv;
    }

    public boolean search(int data) {
        return search(root, data);
    }

    private boolean search(Node node, int data) {
        if (node == null) {
            return false;
        } else if (node.data == data) {
            return true;
        } else if (data <= node.data) {
            return search(node.left, data);
        } else {
            return search(node.right, data);
        }
    }

    public int height() {
        return height(root);
    }

    private int height(Node node) {
        if (node == null) {
            return -1;
        }
        int leftHeight = height(node.left);
        int rightHeight = height(node.right);
        return 1 + Math.max(leftHeight, rightHeight);
    }

    public int diameter() {
        return diameter(root);
    }

    private int diameter(Node node) {
        if (node == null) {
            return 0;
        }
        int leftHeight = height(node.left);
        int rightHeight = height(node.right);
        int leftDiameter = diameter(node.left);
        int rightDiameter = diameter(node.right);
        return Math.max(leftHeight + rightHeight + 2, Math.max(leftDiameter, rightDiameter));
    }

    public void printLevelOrder() {
        Queue<Node> queue = new LinkedList<>();
        queue.add(root);
        while (!queue.isEmpty()) {
            Node node = queue.poll();
            System.out.print(node.data + " ");
            if (node.left != null) {
                queue.add(node.left);
            }
            if (node.right != null) {
                queue.add(node.right);
            }
        }
        System.out.println();
    }

    public boolean isBalanced() {
        return isBalanced(root);
    }


    private boolean isBalanced(Node node) {
        if (node == null) {
            return true;
        }

        int leftHeight = height(node.left);
        int rightHeight = height(node.right);

        if (Math.abs(leftHeight - rightHeight) > 1) {
            return false;
        }

        return isBalanced(node.left) && isBalanced(node.right);
    }

    public Node getLCA(int data1, int data2) {
        return getLCA(root, data1, data2);
    }

    private Node getLCA(Node node, int data1, int data2) {
        if (node == null) {
            return null;
        }

        if (node.data == data1 || node.data == data2) {
            return node;
        }

        Node leftLCA = getLCA(node.left, data1, data2);
        Node rightLCA = getLCA(node.right, data1, data2);

        if (leftLCA != null && rightLCA != null) {
            return node;
        }

        return (leftLCA != null) ? leftLCA : rightLCA;
    }

    public static void main(String[] args) {
        BinaryTree tree = new BinaryTree();

        // Add nodes to binary tree
        tree.insert(10);
        tree.insert(5);
        tree.insert(20);
        tree.insert(3);
        tree.insert(7);
        tree.insert(15);
        tree.insert(25);


        tree.delete(7);


        System.out.println(tree.search(20));
        System.out.println(tree.search(7));


        System.out.println(tree.height());


        System.out.println(tree.diameter());

        tree.printLevelOrder();


        System.out.println(tree.isBalanced());


        Node lca = tree.getLCA(3, 25);
        System.out.println(lca.data);
    }



}
