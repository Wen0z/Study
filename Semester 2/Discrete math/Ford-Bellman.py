def ford_bellman(graph, start):
    distance = {vertex: float('infinity') for vertex in graph}
    distance[start] = 0

    for i in range(len(graph) - 1):
        for vertex in graph:
            for neighbour, weight in graph[vertex].items():
                if distance[vertex] + weight < distance[neighbour]:
                    distance[neighbour] = distance[vertex] + weight

    for vertex in graph:
        for neighbour, weight in graph[vertex].items():
            if distance[vertex] + weight < distance[neighbour]:
                print("Invalid graph")
                return None

    return distance

graph = {
    'A': {'B': -1, 'C': 4},
    'B': {'C': 3, 'D': 2, 'E': 2},
    'C': {},
    'D': {'B': 1, 'C': 5},
    'E': {'D': -3}
}

distances = ford_bellman(graph, 'A')
print(distances)
