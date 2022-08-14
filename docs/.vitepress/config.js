import { defineConfig } from "vitepress";

export default defineConfig({
  title: "StreamerBotTools",
  base: "/StreamerBotTools/",
  srcDir: "src",
  themeConfig: {
    nav: [
      {
        text: "API",
        link: "/api/WindowMover/WindowFinder",
        activeMatch: "/api/*",
      },
      {
        text: "Download",
        link: "https://github.com/maniek335/StreamerBotTools/releases",
      },
    ],
    socialLinks: [
      { icon: "github", link: "https://github.com/maniek335/StreamerBotTools" },
    ],
    sidebar: {
      "/api": [
        {
          text: "WindowMover",
          items: [
            { text: "WindowFinder", link: "/api/WindowMover/WindowFinder" },
            { text: "WindowHandle", link: "/api/WindowMover/WindowHandle" },
          ],
        },
      ],
    },
    editLink: {
      text: "Edit this page on GitHub",
      pattern:
        "https://github.com/maniek335/StreamerBotTools/blob/main/docs/src/:path",
    },
    footer: {
      copyright: `Copyright © 2022-${new Date().getFullYear()} Kubisz Mariusz`,
    },
  },
});
