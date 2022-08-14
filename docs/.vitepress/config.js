import { defineConfig } from "vitepress";

export default defineConfig({
  title: "StreamerBotTools",
  base: "/StreamerBotTools/",
  srcDir: "src",
  lastUpdated: true,
  themeConfig: {
    socialLinks: [
      { icon: "github", link: "https://github.com/maniek335/StreamerBotTools" },
    ],
    footer: {
      copyright: `Copyright © 2022-${new Date().getFullYear()} Kubisz Mariusz`,
    },
  },
});
