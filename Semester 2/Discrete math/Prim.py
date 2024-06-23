def prim(edges, num_vertices):
    adj_list = {i: [] for i in range(num_vertices)}
    for weight, v1, v2 in edges:
        adj_list[v1].append((v2, weight))
        adj_list[v2].append((v1, weight))

    mst_set = set([0])
    result = []

    while len(mst_set) < num_vertices:
        min_edge = (None, None, float('inf'))
        for vertex in mst_set:
            for adj_vertex, weight in adj_list[vertex]:
                if adj_vertex not in mst_set and weight < min_edge[2]:
                    min_edge = (vertex, adj_vertex, weight)
        result.append(min_edge)
        mst_set.add(min_edge[1])

    return result

edges = [
    (9, 0, 1),
    (75, 0, 2),
    (95, 1, 2),
    (19, 1, 3),
    (42, 1, 4),
    (51, 2, 3),
    (66, 2, 4),
    (31, 3, 4)
]

num_vertices = 5

mst_edges = prim(edges, num_vertices)
for v1, v2, weight in mst_edges:
    print(f"({v1}, {v2}) - {weight}")
