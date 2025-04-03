FROM node:lts-alpine AS base

WORKDIR /app

ENV PNPM_HOME="/pnpm"
ENV PATH="$PNPM_HOME:$PATH"
RUN corepack enable

COPY . .

WORKDIR /app/projects-browser
RUN pnpm install --prefer-offline --prod --no-frozen-lockfile --prefer-offline --force
RUN pnpm run prebuild
RUN pnpm run build

FROM node:lts-alpine AS production
WORKDIR /app
COPY --from=base /app/projects-browser/dist ./dist
CMD ["echo", "Build complete"]