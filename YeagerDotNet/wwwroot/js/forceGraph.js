window.forceGraph = {
    init: function (containerId, nodes, edges) {
      // Create a graph
      const graph = { nodes: nodes, edges: edges };
  
      // Empty the container
      const container = document.getElementById(containerId);
      container.innerHTML = "";
  
      // Instantiate sigma
      const renderer = new sigma.Renderer(container, graph, {
        defaultNodeColor: "#008080",
        defaultEdgeColor: "#cccccc",
        edgeColor: "default",
        animationsTime: 1000,
      });
  
      // Use the forceAtlas2 layout for an animated “particle” look
      const fa2 = sigma.layouts.fruchtermanReingold.configure(renderer, {
        iterations: 1000,
        settings: {
          gravity: 1,
          scalingRatio: 2,
        }
      });
  
      // Start layout
      sigma.layouts.fruchtermanReingold.start(renderer, fa2);
  
      // When you click a node, log it
      renderer.bind("clickNode", (e) => {
        console.log("Clicked node", e.data.node.label);
      });
    }
  };
  